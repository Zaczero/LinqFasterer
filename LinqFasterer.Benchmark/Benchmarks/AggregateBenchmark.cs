using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class AggregateBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int AggregateLinq()
        {
            return Data.Aggregate((l, r) => l ^ r);
        }

        [Benchmark]
        public int AggregateFaster()
        {
            return Data.AggregateF((l, r) => l ^ r);
        }
    }
}
