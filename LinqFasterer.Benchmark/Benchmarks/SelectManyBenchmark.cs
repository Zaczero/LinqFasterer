using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class SelectManyBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] SelectManyLinq()
        {
            return Data.SelectMany(i => new [] {i, i, i}).ToArray();
        }

        [Benchmark]
        public int[] SelectManyFaster()
        {
            return Data.SelectManyF(i => new [] {i, i, i}).ToArrayF();
        }
    }
}