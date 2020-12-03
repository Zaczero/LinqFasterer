using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class OrderByBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] OrderByLinq()
        {
            return Data.OrderBy(v => v).ToArray();
        }

        [Benchmark]
        public int[] OrderByFaster()
        {
            return Data.OrderByF(v => v).ToArrayF();
        }
    }
}