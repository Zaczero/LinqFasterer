using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
{
	public class ContainsBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public bool ContainsLinq()
		{
			return Data.Contains(-5);
		}

		[Benchmark]
		public bool ContainsFaster()
		{
			return Data.ContainsF(-5);
		}
	}
}