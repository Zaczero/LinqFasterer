using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class LastBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int LastPredicateLinq()
		{
			return Data.Last(v => v < -1);
		}

		[Benchmark]
		public int LastPredicateFaster()
		{
			return Data.LastF(v => v < -1);
		}
	}
}