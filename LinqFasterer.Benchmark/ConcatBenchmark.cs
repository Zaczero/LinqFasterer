using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
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
}