using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class DistinctBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int[] DistinctLinq()
		{
			return Data.Distinct().ToArray();
		}

		[Benchmark]
		public int[] DistinctFaster()
		{
			return Data.DistinctF().ToArray();
		}
	}
}
