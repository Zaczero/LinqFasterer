using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class SkipBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] SkipLinq()
        {
            return Data.Skip(5).ToArray();
        }

        [Benchmark]
        public int[] SkipFaster()
        {
            return Data.SkipF(5).ToArrayF();
        }
    }
}