using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class ToCastBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public int[] ToArrayLinq()
		{
			return Data.ToArray();
		}

		[Benchmark]
		public int[] ToArrayFaster()
		{
			return Data.ToArrayF();
		}

		[Benchmark]
		public int[] ToArrayFromListLinq()
		{
			// ReSharper disable once RemoveToList.1
			return Data.ToList().ToArray();
		}

		[Benchmark]
		public int[] ToArrayFromListFaster()
		{
			return Data.ToList().ToArrayF();
		}

		[Benchmark]
		public List<int> ToListLinq()
		{
			return Data.ToList();
		}

		[Benchmark]
		public List<int> ToListFaster()
		{
			return Data.ToListF();
		}
	}
}