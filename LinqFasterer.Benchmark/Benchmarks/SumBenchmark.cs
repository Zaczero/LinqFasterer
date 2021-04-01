using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class SumBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int SumLinq()
        {
            return Data.Sum();
        }

        [Benchmark]
        public int SumFaster()
        {
            return Data.SumF();
        }

        [Benchmark]
        public int SumFaster4()
        {
            return Data.SumF4();
        }

        [Benchmark]
        public int SumFaster16()
        {
            return Data.SumF16();
        }
    }
}
