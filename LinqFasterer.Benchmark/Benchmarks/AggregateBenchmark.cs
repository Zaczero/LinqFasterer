using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	// TODO: split into different classes, search by checking IBenchmarkable interface
	public class AggregateBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int AggregateLinq()
		{
			return Data.Aggregate((l, r) => l);
		}

		[Benchmark]
		public int AggregateFaster()
		{
			return Data.AggregateF((l, r) => l);
		}
	}
}
