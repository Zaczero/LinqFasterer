using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
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