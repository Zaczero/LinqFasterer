using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class FirstBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int FirstPredicateLinq()
		{
			return Data.FirstOrDefault(v => v < -1);
		}

		[Benchmark]
		public int FirstPredicateFaster()
		{
			return Data.FirstOrDefaultF(v => v < -1);
		}
	}
}