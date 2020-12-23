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
}