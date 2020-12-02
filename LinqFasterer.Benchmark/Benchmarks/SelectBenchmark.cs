using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class SelectBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] SelectLinq()
        {
            return Data.Select(i => -i).ToArray();
        }

        [Benchmark]
        public int[] SelectFaster()
        {
            return Data.SelectF(i => -i).ToArrayF();
        }

        [Benchmark]
        public int[] SelectInPlaceFaster()
        {
            return Data.SelectInPlaceF(i => -i).ToArrayF();
        }
    }
}