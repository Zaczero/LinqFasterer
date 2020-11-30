using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
{
	[SimpleJob(launchCount:1, warmupCount:1, targetCount:4)]
	//[SimpleJob(launchCount:1, warmupCount:2, targetCount:10)]
	[MemoryDiagnoser]
	public class Benchmarkable
	{
		//[Params(50000)]
		[Params(0, 1, 3, 5, 10, 50, 100, 250, 500, 1000, 1500, 2000, 2500, 3000, 5000, 10_000, 50_000, 100_000, 500_000, 1_000_000)]
		public int N;

		protected int[] Data;
		protected int[] DataSecondary;

		[GlobalSetup]
		public void GlobalSetup()
		{
			Data = Utilities.TestArray(typeof(int), N, 0, 1000).ToArray()[0][0] as int[];
			DataSecondary = Utilities.TestArray(typeof(int), N, 500, 1500).ToArray()[0][0] as int[];
		}
	}
}
