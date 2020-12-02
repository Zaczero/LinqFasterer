using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class ElementAtBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int ElementAtLinq()
        {
            return Data.ElementAt(5);
        }

        [Benchmark]
        public int ElementAtFaster()
        {
            return Data.ElementAtF(5);
        }
    }
}