using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class WhereBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int[] WhereLinq()
		{
			return Data.Where(v => v > 10).ToArray();
		}

		[Benchmark]
		public int[] WhereFaster()
		{
			return Data.WhereF(v => v > 10).ToArrayF();
		}

		[Benchmark]
		public int[] WhereIndexedLinq()
		{
			return Data.Where((v, _) => v > 10).ToArray();
		}

		[Benchmark]
		public int[] WhereIndexedFaster()
		{
			return Data.WhereF((v, _) => v > 10).ToArrayF();
		}

		//[Benchmark]
		//public int[] WhereIndexedLinq()
		//{
		//	return Data.Where((v, i) => v > 10).ToArray();
		//}

		//[Benchmark]
		//public int[] WhereIndexedFaster()
		//{
		//	return Data.WhereF((v, i) => v > 10).ToArrayF();
		//}
	}
}