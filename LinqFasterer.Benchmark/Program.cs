using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using LinqFasterer.Benchmarks.Benchmarks;
using System;

namespace LinqFasterer.Benchmarks
{
	public static class Program
	{
		public static int Main()
		{
			var summary = BenchmarkRunner.Run<FirstBenchmark>(ManualConfig.Create(DefaultConfig.Instance));
			if (summary.HasCriticalValidationErrors)
				return -1;

			Console.ReadLine();
			return 0;
		}
	}
}
