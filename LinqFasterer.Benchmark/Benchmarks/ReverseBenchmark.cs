using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class ReverseBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] ReverseLinq()
        {
            return Data.Reverse().ToArray();
        }

        [Benchmark]
        public int[] ReverseFaster()
        {
            return Data.ReverseF().ToArrayF();
        }
    }
}