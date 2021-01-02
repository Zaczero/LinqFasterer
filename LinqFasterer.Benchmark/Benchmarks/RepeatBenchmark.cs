using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class RepeatBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] RepeatLinq()
        {
            return Enumerable.Repeat(5, N).ToArray();
        }

        [Benchmark]
        public int[] RepeatFaster()
        {
            return EnumerableF.RepeatF(5, N).ToArrayF();
        }
    }
    
    public class RepeatSequenceBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] RepeatSequenceFaster()
        {
            return EnumerableF.RepeatSequenceF(new[] {1, 2, 3, 4, 5}, N).ToArrayF();
        }
    }
}