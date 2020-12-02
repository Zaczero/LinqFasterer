using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class PrependBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] PrependLinq()
        {
            return Data.Prepend(5).ToArray();
        }

        [Benchmark]
        public int[] PrependFaster()
        {
            return Data.PrependF(5).ToArrayF();
        }
    }
}