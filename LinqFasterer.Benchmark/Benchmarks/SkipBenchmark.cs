using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class SkipBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] SkipLinq()
        {
            return Data.Skip(5).ToArray();
        }

        [Benchmark]
        public int[] SkipFaster()
        {
            return Data.SkipF(5).ToArrayF();
        }
    }
    
    public class SkipLastBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] SkipLastLinq()
        {
            return Data.SkipLast(5).ToArray();
        }

        [Benchmark]
        public int[] SkipLastFaster()
        {
            return Data.SkipLastF(5).ToArrayF();
        }
    }
}