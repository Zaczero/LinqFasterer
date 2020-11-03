using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
{
	public class ZipBenchmark : Benchmarkable
	{
		//[Benchmark(Baseline = true)]
		//public (int, int)[] ZipLinq()
		//{
		//	return Data.Zip(DataSecondary).ToArray();
		//}

		//[Benchmark]
		//public (int, int)[] ZipFaster()
		//{
		//	return Data.ZipF(DataSecondary).ToArrayF();
		//}

		[Benchmark(Baseline = true)]
		public int[] ZipSelectorLinq()
		{
			return Data.Zip(DataSecondary, (l, r) => l + r).ToArray();
		}

		[Benchmark]
		public int[] ZipSelectorFaster()
		{
			return Data.ZipF(DataSecondary, (l, r) => l + r).ToArrayF();
		}
	}
}