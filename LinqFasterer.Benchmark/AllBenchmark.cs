using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
{
	public class AllBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public bool AllLinq()
		{
			return Data.All(v => v > -1);
		}

		[Benchmark]
		public bool AllFaster()
		{
			return Data.AllF(v => v > -1);
		}
	}
}