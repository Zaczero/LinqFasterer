using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class ConcatBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] ConcatLinq()
        {
            return Data.Concat(DataSecondary).ToArray();
        }

        [Benchmark]
        public int[] ConcatFaster()
        {
            return Data.ConcatF(DataSecondary).ToArrayF();
        }
    }
    
    public class ConcatMultipleBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] ConcatMultipleFaster()
        {
            return EnumerableF.ConcatMultipleF(Data, DataSecondary, Data, DataSecondary).ToArrayF();
        }
    }
    
    public class ConcatMultipleStrBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public string ConcatMultipleStrFaster()
        {
            return EnumerableF.ConcatMultipleF(Data.SelectF(i => i.ToString()).ToArrayF());
        }
    }
}