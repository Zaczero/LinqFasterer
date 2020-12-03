using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class MinBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int MinLinq()
        {
            return Data.Min();
        }

        [Benchmark]
        public int MinFaster()
        {
            return Data.MinF();
        }
    }
}