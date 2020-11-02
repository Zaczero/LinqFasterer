using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
{
	public class UnionBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int[] UnionLinq()
		{
			return Data.Union(DataSecondary).ToArray();
		}

		[Benchmark]
		public int[] UnionFaster()
		{
			return Data.UnionF(DataSecondary).ToArrayF();
		}
	}
}