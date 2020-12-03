using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
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
	}
	
	public class ContainsComparerBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
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