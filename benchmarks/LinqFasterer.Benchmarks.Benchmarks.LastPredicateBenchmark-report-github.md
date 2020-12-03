``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host] : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|              Method |       N |
|-------------------- |-------- |
|   **LastPredicateLinq** |       **0** |
| LastPredicateFaster |       0 |
|                     |         |
|   **LastPredicateLinq** |       **1** |
| LastPredicateFaster |       1 |
|                     |         |
|   **LastPredicateLinq** |       **3** |
| LastPredicateFaster |       3 |
|                     |         |
|   **LastPredicateLinq** |       **5** |
| LastPredicateFaster |       5 |
|                     |         |
|   **LastPredicateLinq** |      **10** |
| LastPredicateFaster |      10 |
|                     |         |
|   **LastPredicateLinq** |      **50** |
| LastPredicateFaster |      50 |
|                     |         |
|   **LastPredicateLinq** |     **100** |
| LastPredicateFaster |     100 |
|                     |         |
|   **LastPredicateLinq** |     **250** |
| LastPredicateFaster |     250 |
|                     |         |
|   **LastPredicateLinq** |     **500** |
| LastPredicateFaster |     500 |
|                     |         |
|   **LastPredicateLinq** |    **1000** |
| LastPredicateFaster |    1000 |
|                     |         |
|   **LastPredicateLinq** |    **1500** |
| LastPredicateFaster |    1500 |
|                     |         |
|   **LastPredicateLinq** |    **2000** |
| LastPredicateFaster |    2000 |
|                     |         |
|   **LastPredicateLinq** |    **2500** |
| LastPredicateFaster |    2500 |
|                     |         |
|   **LastPredicateLinq** |    **3000** |
| LastPredicateFaster |    3000 |
|                     |         |
|   **LastPredicateLinq** |    **5000** |
| LastPredicateFaster |    5000 |
|                     |         |
|   **LastPredicateLinq** |   **10000** |
| LastPredicateFaster |   10000 |
|                     |         |
|   **LastPredicateLinq** |   **50000** |
| LastPredicateFaster |   50000 |
|                     |         |
|   **LastPredicateLinq** |  **100000** |
| LastPredicateFaster |  100000 |
|                     |         |
|   **LastPredicateLinq** |  **500000** |
| LastPredicateFaster |  500000 |
|                     |         |
|   **LastPredicateLinq** | **1000000** |
| LastPredicateFaster | 1000000 |

Benchmarks with issues:
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=3]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=3]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=5]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=5]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=10]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=10]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=50]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=50]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=100]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=100]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=250]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=250]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=500]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=500]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1000]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1000]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1500]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1500]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=2000]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=2000]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=2500]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=2500]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=3000]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=3000]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=5000]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=5000]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=10000]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=10000]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=50000]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=50000]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=100000]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=100000]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=500000]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=500000]
  LastPredicateBenchmark.LastPredicateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1000000]
  LastPredicateBenchmark.LastPredicateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1000000]
