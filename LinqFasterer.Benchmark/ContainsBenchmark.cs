using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LinqFasterer.Benchmarks
{
	public class ContainsBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public bool ContainsLinq()
		{
			return Data.Contains(-5);
		}

		[Benchmark]
		public bool ContainsFaster()
		{
			return Data.ContainsF(-5);
		}

		[Benchmark]
		public bool ContainsComparerLinq()
		{
			return Data.Contains(-5, EqualityComparer<int>.Default);
		}

		[Benchmark]
		public bool ContainsComparerFaster()
		{
			return Data.ContainsF(-5, EqualityComparer<int>.Default);
		}
	}
}