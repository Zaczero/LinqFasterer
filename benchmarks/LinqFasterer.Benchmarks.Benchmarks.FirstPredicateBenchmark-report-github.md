``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host] : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|               Method |       N |
|--------------------- |-------- |
|   **FirstPredicateLinq** |       **0** |
| FirstPredicateFaster |       0 |
|                      |         |
|   **FirstPredicateLinq** |       **1** |
| FirstPredicateFaster |       1 |
|                      |         |
|   **FirstPredicateLinq** |       **3** |
| FirstPredicateFaster |       3 |
|                      |         |
|   **FirstPredicateLinq** |       **5** |
| FirstPredicateFaster |       5 |
|                      |         |
|   **FirstPredicateLinq** |      **10** |
| FirstPredicateFaster |      10 |
|                      |         |
|   **FirstPredicateLinq** |      **50** |
| FirstPredicateFaster |      50 |
|                      |         |
|   **FirstPredicateLinq** |     **100** |
| FirstPredicateFaster |     100 |
|                      |         |
|   **FirstPredicateLinq** |     **250** |
| FirstPredicateFaster |     250 |
|                      |         |
|   **FirstPredicateLinq** |     **500** |
| FirstPredicateFaster |     500 |
|                      |         |
|   **FirstPredicateLinq** |    **1000** |
| FirstPredicateFaster |    1000 |
|                      |         |
|   **FirstPredicateLinq** |    **1500** |
| FirstPredicateFaster |    1500 |
|                      |         |
|   **FirstPredicateLinq** |    **2000** |
| FirstPredicateFaster |    2000 |
|                      |         |
|   **FirstPredicateLinq** |    **2500** |
| FirstPredicateFaster |    2500 |
|                      |         |
|   **FirstPredicateLinq** |    **3000** |
| FirstPredicateFaster |    3000 |
|                      |         |
|   **FirstPredicateLinq** |    **5000** |
| FirstPredicateFaster |    5000 |
|                      |         |
|   **FirstPredicateLinq** |   **10000** |
| FirstPredicateFaster |   10000 |
|                      |         |
|   **FirstPredicateLinq** |   **50000** |
| FirstPredicateFaster |   50000 |
|                      |         |
|   **FirstPredicateLinq** |  **100000** |
| FirstPredicateFaster |  100000 |
|                      |         |
|   **FirstPredicateLinq** |  **500000** |
| FirstPredicateFaster |  500000 |
|                      |         |
|   **FirstPredicateLinq** | **1000000** |
| FirstPredicateFaster | 1000000 |

Benchmarks with issues:
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=3]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=3]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=5]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=5]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=10]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=10]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=50]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=50]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=100]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=100]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=250]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=250]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=500]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=500]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1000]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1000]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1500]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1500]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=2000]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=2000]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=2500]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=2500]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=3000]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=3000]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=5000]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=5000]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=10000]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=10000]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=50000]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=50000]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=100000]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=100000]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=500000]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=500000]
  FirstPredicateBenchmark.FirstPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1000000]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1000000]
