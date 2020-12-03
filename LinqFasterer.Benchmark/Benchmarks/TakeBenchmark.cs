using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class TakeBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] TakeLinq()
        {
            return Data.Take(5).ToArray();
        }

        [Benchmark]
        public int[] TakeFaster()
        {
            return Data.TakeF(5).ToArrayF();
        }
    }
    
    public class TakeLastBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] TakeLastLinq()
        {
            return Data.TakeLast(5).ToArray();
        }

        [Benchmark]
        public int[] TakeLastFaster()
        {
            return Data.TakeLastF(5).ToArrayF();
        }
    }
}