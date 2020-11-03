using BenchmarkDotNet.Attributes;
using System;

namespace LinqFasterer.Benchmarks
{
	public class CustomBenchmark : Benchmarkable
	{
		//[Benchmark(Baseline = true)]
		//public int[] ArrayCopy()
		//{
		//	var arr = new int[Data.Length / 2];

		//	Array.Copy(Data, 0, arr, 0, arr.Length);

		//	return arr;
		//}

		//[Benchmark]
		//public int[] ArrayResize()
		//{
		//	Array.Resize(ref Data, Data.Length / 2);

		//	return Data;
		//}

		[Benchmark(Baseline = true)]
		public int[] ArrayCopy()
		{
			var arr = new int[Data.Length];

			Array.Copy(Data, 0, arr, 0, arr.Length);

			return arr;
		}

		[Benchmark]
		public int[] ArrayCopyTo()
		{
			var arr = new int[Data.Length];

			Data.CopyTo(arr, 0);

			return Data;
		}

		[Benchmark]
		public int[] ArraySpan()
		{
			return Data.AsSpan().ToArray();
		}
	}
}