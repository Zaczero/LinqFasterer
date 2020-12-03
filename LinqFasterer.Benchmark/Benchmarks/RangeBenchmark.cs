using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class RangeBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] RangeLinq()
        {
            return Enumerable.Range(0, 100).ToArray();
        }

        [Benchmark]
        public int[] RangeFaster()
        {
            return LinqFasterer.RangeF(0, 100).ToArrayF();
        }
    }
}