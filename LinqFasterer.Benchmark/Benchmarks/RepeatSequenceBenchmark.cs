using BenchmarkDotNet.Attributes;

namespace LinqFasterer.Benchmarks.Benchmarks
{
    public class RepeatSequenceBenchmark : Benchmarkable
    {
        [Benchmark(Baseline = true)]
        public int[] RepeatSequenceFaster()
        {
            return EnumerableF.RepeatSequenceF(new[] {1, 2, 3, 4, 5}, N).ToArrayF();
        }
    }
}