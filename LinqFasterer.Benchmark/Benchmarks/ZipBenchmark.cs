using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class ZipBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public (int, int)[] ZipLinq()
		{
			return Data.Zip(DataSecondary).ToArray();
		}

		[Benchmark]
		public (int, int)[] ZipFaster()
		{
			return Data.ZipF(DataSecondary).ToArrayF();
		}
	}
	
	public class ZipSelectorBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int[] ZipSelectorLinq()
		{
			return Data.ToList().Zip(DataSecondary, (l, r) => l + r).ToArray();
		}

		[Benchmark]
		public int[] ZipSelectorFaster()
		{
			return Data.ToList().ZipF(DataSecondary, (l, r) => l + r).ToArrayF();
		}
	}
}