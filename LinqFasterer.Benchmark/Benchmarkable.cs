using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
{
	[SimpleJob(launchCount:1, warmupCount:2, targetCount:6)]
	[MemoryDiagnoser]
	public class Benchmarkable
	{
		[Params(10, 1000, 100000)]
		public int N;

		protected int[] Data;

		[GlobalSetup]
		public void GlobalSetup()
		{
			Data = Utilities.TestArray(typeof(int), N, 0, 1000).ToArray()[0][0] as int[];
		}
	}
}
