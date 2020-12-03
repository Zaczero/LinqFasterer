using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class IntersectBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] IntersectLinq()
        {
            return Data.Intersect(DataSecondary).ToArray();
        }

        [Benchmark]
        public int[] IntersectFaster()
        {
            return Data.IntersectF(DataSecondary).ToArrayF();
        }
    }
}