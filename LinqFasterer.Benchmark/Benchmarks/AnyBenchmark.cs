using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class AnyBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public bool AnyLinq()
		{
			return Data.Any(v => v > -1);
		}

		[Benchmark]
		public bool AnyFaster()
		{
			return Data.AnyF(v => v > -1);
		}
	}
}