﻿using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class ConcatBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] ConcatLinq()
        {
            return Data.Concat(DataSecondary).ToArray();
        }

        [Benchmark]
        public int[] ConcatFaster()
        {
            return Data.ConcatF(DataSecondary).ToArrayF();
        }
    }
}