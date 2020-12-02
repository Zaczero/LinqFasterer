using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class MaxBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int MaxLinq()
        {
            return Data.Max();
        }

        [Benchmark]
        public int MaxFaster()
        {
            return Data.MaxF();
        }
    }
}