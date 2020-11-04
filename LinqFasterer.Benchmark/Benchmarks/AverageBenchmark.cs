using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
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