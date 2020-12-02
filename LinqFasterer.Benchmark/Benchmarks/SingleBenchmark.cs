using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class SingleBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int SingleLinq()
        {
            Data[Data.Length / 2] = -1;
            return Data.Single(i => i == -1);
        }

        [Benchmark]
        public int SingleFaster()
        {
            Data[Data.Length / 2] = -1;
            return Data.SingleF(i => i == -1);
        }
    }
}