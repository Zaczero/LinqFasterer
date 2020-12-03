``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-GMHRDE : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|              Method |       N |        Mean |      Error |    StdDev | Ratio | RatioSD |
|-------------------- |-------- |------------:|-----------:|----------:|------:|--------:|
|   **LastPredicateLinq** |       **0** |          **NA** |         **NA** |        **NA** |     **?** |       **?** |
| LastPredicateFaster |       0 |          NA |         NA |        NA |     ? |       ? |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |       **1** |    **23.85 ns** |   **0.724 ns** |  **0.479 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |       1 |    13.83 ns |   0.203 ns |  0.134 ns |  0.58 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |       **3** |    **28.84 ns** |   **1.203 ns** |  **0.629 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |       3 |    17.62 ns |   0.310 ns |  0.205 ns |  0.61 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |       **5** |    **33.49 ns** |   **0.464 ns** |  **0.276 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |       5 |    19.66 ns |   0.515 ns |  0.341 ns |  0.59 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |      **10** |    **39.81 ns** |   **0.631 ns** |  **0.417 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |      10 |    23.07 ns |   0.635 ns |  0.420 ns |  0.58 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |      **50** |   **124.29 ns** |   **1.828 ns** |  **1.088 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |      50 |    77.79 ns |   1.050 ns |  0.695 ns |  0.63 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |     **100** |   **218.96 ns** |   **2.939 ns** |  **1.944 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |     100 |   135.04 ns |   1.448 ns |  0.958 ns |  0.62 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |     **250** |   **505.26 ns** |   **4.599 ns** |  **3.042 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |     250 |   304.37 ns |   9.006 ns |  5.359 ns |  0.60 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |     **500** |    **64.22 ns** |   **1.111 ns** |  **0.735 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |     500 |    32.22 ns |   0.453 ns |  0.269 ns |  0.50 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |    **1000** | **1,932.77 ns** |  **16.537 ns** | **10.938 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |    1000 | 1,158.51 ns |   9.492 ns |  6.278 ns |  0.60 |    0.00 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |    **1500** | **2,247.39 ns** |  **14.781 ns** |  **9.777 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |    1500 | 1,340.68 ns |  40.670 ns | 24.202 ns |  0.60 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |    **2000** | **1,495.32 ns** |  **24.058 ns** | **15.913 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |    2000 |   901.97 ns |  14.441 ns |  8.593 ns |  0.60 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |    **2500** | **2,285.43 ns** |  **13.575 ns** |  **8.979 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |    2500 | 1,359.34 ns |  14.841 ns |  9.817 ns |  0.59 |    0.00 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |    **3000** | **3,370.15 ns** |  **47.471 ns** | **31.399 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |    3000 | 2,029.04 ns |   8.880 ns |  5.874 ns |  0.60 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |    **5000** | **1,417.43 ns** |  **17.158 ns** | **11.349 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |    5000 |   795.81 ns |   9.979 ns |  6.601 ns |  0.56 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |   **10000** | **6,220.47 ns** |  **22.445 ns** | **13.357 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |   10000 | 3,722.59 ns |  21.227 ns | 12.632 ns |  0.60 |    0.00 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |   **50000** |   **866.80 ns** |   **5.882 ns** |  **3.890 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |   50000 |   527.34 ns |  15.805 ns | 10.454 ns |  0.61 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |  **100000** |   **616.13 ns** |   **6.520 ns** |  **4.312 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |  100000 |   366.88 ns |   2.795 ns |  1.849 ns |  0.60 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** |  **500000** | **3,369.80 ns** | **114.638 ns** | **75.826 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster |  500000 | 1,964.27 ns |   5.814 ns |  3.460 ns |  0.58 |    0.01 |
|                     |         |             |            |           |       |         |
|   **LastPredicateLinq** | **1000000** | **1,063.20 ns** |   **3.989 ns** |  **2.639 ns** |  **1.00** |    **0.00** |
| LastPredicateFaster | 1000000 |   637.42 ns |   3.308 ns |  2.188 ns |  0.60 |    0.00 |

Benchmarks with issues:
  LastPredicateBenchmark.LastPredicateLinq: Job-GMHRDE(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
  LastPredicateBenchmark.LastPredicateFaster: Job-GMHRDE(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
