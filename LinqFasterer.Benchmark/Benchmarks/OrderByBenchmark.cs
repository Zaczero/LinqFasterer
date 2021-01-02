﻿using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class OrderByBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] OrderByLinq()
        {
            return Data.OrderBy(v => v).ToArray();
        }

        [Benchmark]
        public int[] OrderByFaster()
        {
            return Data.OrderByF(v => v).ToArrayF();
        }

        [Benchmark]
        public int[] OrderFaster()
        {
            return Data.OrderF().ToArrayF();
        }
    }
    
    public class OrderByDescendingBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] OrderByDescendingLinq()
        {
            return Data.OrderByDescending(v => v).ToArray();
        }

        [Benchmark]
        public int[] OrderByDescendingFaster()
        {
            return Data.OrderByDescendingF(v => v).ToArrayF();
        }

        [Benchmark]
        public int[] OrderDescendingFaster()
        {
            return Data.OrderDescendingF().ToArrayF();
        }
    }
}