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

        [Benchmark]
        public int[] SortFaster()
        {
            return Data.SortF().ToArrayF();
        }
    }
    
    public class OrderByDescendingBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] OrderByDescendingLinq()
        {
            return Data.OrderByDescending(v => v).ToArray();
        }

        [Benchmark]
        public int[] OrderByDescendingFaster()
        {
            return Data.OrderByDescendingF(v => v).ToArrayF();
        }

        [Benchmark]
        public int[] SortDescendingFaster()
        {
            return Data.SortDescendingF().ToArrayF();
        }
    }
}