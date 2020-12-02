using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class DefaultIfEmptyBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] DefaultIfEmptyLinq()
        {
            return Data.DefaultIfEmpty().ToArray();
        }

        [Benchmark]
        public int[] DefaultIfEmptyFaster()
        {
            return Data.DefaultIfEmptyF().ToArrayF();
        }
    }
}