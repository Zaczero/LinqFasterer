using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class ExceptBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int[] ExceptLinq()
		{
			return Data.Except(DataSecondary).ToArray();
		}

		[Benchmark]
		public int[] ExceptFaster()
		{
			return Data.ExceptF(DataSecondary).ToArrayF();
		}
	}
}