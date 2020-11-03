using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
{
	public class SumBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int SumLinq()
		{
			return Data.Sum();
		}

		[Benchmark]
		public int SumFaster()
		{
			return Data.SumF();
		}
	}
}