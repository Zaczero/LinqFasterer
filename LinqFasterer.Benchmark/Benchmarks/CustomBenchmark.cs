using System;
using System.Globalization;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
	public class CustomBenchmark : Benchmarkable
	{
		[Benchmark(Baseline = true)]
		public string Classic()
		{
			return $"N = {N}.";
		}

		[Benchmark]
		public string ToString()
		{
			return $"N = {N.ToString(CultureInfo.CurrentCulture)}.";
		}

		[Benchmark]
		public string ToStringInvariant()
		{
			return $"N = {N.ToString(CultureInfo.InvariantCulture)}.";
		}
	}
}