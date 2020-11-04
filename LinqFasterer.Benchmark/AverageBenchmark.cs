using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
{
	public class AverageBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public double AverageLinq()
		{
			return Data.Average();
		}

		[Benchmark]
		public double AverageFaster()
		{
			return Data.AverageF();
		}
	}
}