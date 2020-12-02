using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class SequenceEqualBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public bool SequenceEqualLinq()
        {
            return Data.SequenceEqual(DataSecondary);
        }

        [Benchmark]
        public bool SequenceEqualFaster()
        {
            return Data.SequenceEqualF(DataSecondary);
        }
    }
}