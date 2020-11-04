using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class RepeatBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int[] RepeatLinq()
		{
			return Enumerable.Repeat(5, 100).ToArray();
		}

		[Benchmark]
		public int[] RepeatFaster()
		{
			return LinqFasterer.RepeatF(5, 100).ToArrayF();
		}
	}
}