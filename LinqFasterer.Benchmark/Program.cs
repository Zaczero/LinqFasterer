using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;

namespace LinqFasterer.Benchmarks
{
    public static class Program
    {
        private const string ArtifactsDirectory = "Artifacts/";
        private const string ResultsDirectory = ArtifactsDirectory + "results/";
        private const string MarkdownFileExtension = ".md";
        private const string MergedResultsFilePath = "BenchmarkResult" + MarkdownFileExtension;

        private static readonly Regex ResultRegex = new(@"``` ini\s+(?<resultHeader>.*?)\s+```\s+(?<tableHeader>\|.*?\|)\r?\n(?<tableSeparator>\|.*?\|)\r?\n(?<tableData>\|.*\|)", RegexOptions.Singleline);
        private static readonly Regex TableEntryRegex = new(@"[^|]+", RegexOptions.Singleline);
        
        public static int Main()
        {
            CleanupResults();

            var config = ManualConfig.CreateEmpty()
                .AddLogger(ConsoleLogger.Default)
                .AddColumnProvider(DefaultColumnProviders.Instance)
                .AddDiagnoser(MemoryDiagnoser.Default)
                .AddExporter(MarkdownExporter.GitHub)
                .WithArtifactsPath(ArtifactsDirectory);

            foreach (var benchmark in EnumerateTypes<Benchmarkable>())
            {
                var summary = BenchmarkRunner.Run(benchmark, config);
                if (summary.HasCriticalValidationErrors)
                    return -1;
            }

            using var mergedResultsStream = new FileStream(MergedResultsFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
            using var mergedResultsWriter = new StreamWriter(mergedResultsStream) {AutoFlush = false};
            
            var isResultHeaderCopied = false;
            var tableHeaderFormatted = (string) null;
            
            foreach (var filePath in EnumerateMarkdownFilePaths())
            {
                // This is overcomplicated, there must be an easier way!
                // Documentation: https://benchmarkdotnet.org/articles/overview.html
                // Note: Summary join won't work as `Ratio` column is getting screwed up.

                var fileContent = File.ReadAllText(filePath);

                var resultMatch = ResultRegex.Match(fileContent);
                if (!resultMatch.Success)
                    throw new Exception("Failed to regex-match result file");
                
                var resultHeader = resultMatch.Groups["resultHeader"].Value;
                var tableHeader = resultMatch.Groups["tableHeader"].Value;
                var tableSeparator = resultMatch.Groups["tableSeparator"].Value;
                var tableData = resultMatch.Groups["tableData"].Value;

                if (!isResultHeaderCopied)
                {
                    mergedResultsWriter.WriteLine("``` ini");
                    mergedResultsWriter.WriteLine(resultHeader);
                    mergedResultsWriter.WriteLine("```");
                    mergedResultsWriter.WriteLine();
                    isResultHeaderCopied = true;
                }

                if (tableHeaderFormatted == null)
                {
                    var sb = new StringBuilder("|");

                    foreach (Match match in TableEntryRegex.Matches(tableHeader))
                        sb.Append($" **{match.Value.Trim()}** |");

                    tableHeaderFormatted = sb.ToString();
                    
                    mergedResultsWriter.WriteLine(tableHeader);
                    mergedResultsWriter.WriteLine(tableSeparator);
                }
                else
                {
                    mergedResultsWriter.WriteLine(tableHeaderFormatted);
                }
                
                mergedResultsWriter.WriteLine(tableData);
            }
            
            return 0;
        }

        private static void CleanupResults()
        {
            if (!Directory.Exists(ResultsDirectory))
                return;
            
            Directory.Delete(ResultsDirectory, true);
        }
        
        private static IEnumerable<Type> EnumerateTypes<T>()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var tType = typeof(T);

            foreach (var type in types)
            {
                if (!type.IsClass)
                    continue;

                if (!tType.IsAssignableFrom(type) || tType == type)
                    continue;

                yield return type;
            }
        }

        private static IEnumerable<string> EnumerateMarkdownFilePaths()
        {
            var di = new DirectoryInfo(ResultsDirectory);

            foreach (var fi in di.EnumerateFiles("*" + MarkdownFileExtension))
                yield return fi.FullName;
        }
    }
}
