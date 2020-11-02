﻿using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System;

namespace LinqFasterer.Benchmarks
{
	public static class Program
	{
		public static int Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<UnionBenchmark>(ManualConfig.Create(DefaultConfig.Instance));
			if (summary.HasCriticalValidationErrors)
				return -1;

			Console.ReadLine();
			return 0;
		}
	}
}
