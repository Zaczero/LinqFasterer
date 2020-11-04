using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
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