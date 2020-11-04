using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class AppendBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int[] AppendLinq()
		{
			return Data.Append(5).ToArray();
		}

		[Benchmark]
		public int[] AppendFaster()
		{
			return Data.AppendF(5).ToArrayF();
		}
	}
}