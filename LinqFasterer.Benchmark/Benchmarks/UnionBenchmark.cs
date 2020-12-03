using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class UnionBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] UnionLinq()
        {
            return Data.Union(DataSecondary).ToArray();
        }

        [Benchmark]
        public int[] UnionFaster()
        {
            return Data.UnionF(DataSecondary).ToArrayF();
        }
    }
}