using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
{
	public class CountBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int CountLinq()
		{
			return Data.Count();
		}

		[Benchmark]
		public int CountFaster()
		{
			return Data.CountF();
		}

		[Benchmark]
		public int CountPredicateLinq()
		{
			return Data.Count(v => v % 2 == 0);
		}

		[Benchmark]
		public int CountPredicateFaster()
		{
			return Data.CountF(v => v % 2 == 0);
		}
	}
}