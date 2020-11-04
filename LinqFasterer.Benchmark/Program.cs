using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System;
using LinqFasterer.Benchmarks.Benchmarks;

namespace LinqFasterer.Benchmarks
{
	public static class Program
	{
		public static int Main()
		{
			var summary = BenchmarkRunner.Run<AnyBenchmark>(ManualConfig.Create(DefaultConfig.Instance));
			if (summary.HasCriticalValidationErrors)
				return -1;

			Console.ReadLine();
			return 0;
		}
	}
}
