using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class FirstBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int FirstLinq()
		{
			return Data.First();
		}

		[Benchmark]
		public int FirstFaster()
		{
			return Data.FirstF();
		}
	}
	
	public class FirstPredicateBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int FirstPredicateLinq()
		{
			return Data.First(v => v < -1);
		}

		[Benchmark]
		public int FirstPredicateFaster()
		{
			return Data.FirstF(v => v < -1);
		}
	}
}