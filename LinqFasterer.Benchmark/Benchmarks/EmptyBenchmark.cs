using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class EmptyBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int[] EmptyLinq()
		{
			return Enumerable.Empty<int>().ToArray();
		}

		[Benchmark]
		public int[] EmptyFaster()
		{
			return LinqFasterer.EmptyF<int>().ToArrayF();
		}
	}
}