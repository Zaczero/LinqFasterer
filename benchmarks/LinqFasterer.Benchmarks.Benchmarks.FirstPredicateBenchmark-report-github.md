``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-GMHRDE : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|               Method |       N |         Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------- |-------- |-------------:|----------:|----------:|------:|--------:|
|   **FirstPredicateLinq** |       **0** |           **NA** |        **NA** |        **NA** |     **?** |       **?** |
| FirstPredicateFaster |       0 |           NA |        NA |        NA |     ? |       ? |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |       **1** |     **23.05 ns** |  **0.256 ns** |  **0.153 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |       1 |     12.95 ns |  0.198 ns |  0.118 ns |  0.56 |    0.01 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |       **3** |     **29.38 ns** |  **1.031 ns** |  **0.682 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |       3 |     15.82 ns |  0.288 ns |  0.150 ns |  0.54 |    0.01 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |       **5** |     **36.05 ns** |  **1.463 ns** |  **0.968 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |       5 |     18.37 ns |  0.737 ns |  0.487 ns |  0.51 |    0.02 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |      **10** |     **42.34 ns** |  **0.867 ns** |  **0.573 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |      10 |     20.15 ns |  0.202 ns |  0.134 ns |  0.48 |    0.01 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |      **50** |    **182.62 ns** |  **1.346 ns** |  **0.891 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |      50 |     82.98 ns |  2.837 ns |  1.688 ns |  0.45 |    0.01 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |     **100** |    **329.70 ns** |  **3.036 ns** |  **2.008 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |     100 |    140.36 ns |  4.390 ns |  2.904 ns |  0.43 |    0.01 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |     **250** |    **762.61 ns** |  **3.945 ns** |  **2.348 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |     250 |    309.60 ns |  1.139 ns |  0.678 ns |  0.41 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |     **500** |    **749.29 ns** |  **4.500 ns** |  **2.976 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |     500 |    305.25 ns |  1.737 ns |  0.908 ns |  0.41 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |    **1000** |    **854.98 ns** |  **6.685 ns** |  **4.422 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |    1000 |    346.44 ns |  1.250 ns |  0.827 ns |  0.41 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |    **1500** |  **4,389.65 ns** | **20.492 ns** | **13.554 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |    1500 |  1,717.65 ns | 24.966 ns | 16.513 ns |  0.39 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |    **2000** |  **5,862.86 ns** | **34.415 ns** | **22.763 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |    2000 |  2,290.42 ns | 16.612 ns |  9.886 ns |  0.39 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |    **2500** |  **3,041.06 ns** | **24.539 ns** | **16.231 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |    2500 |  1,195.36 ns |  9.699 ns |  6.415 ns |  0.39 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |    **3000** |    **502.21 ns** |  **1.579 ns** |  **0.826 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |    3000 |    207.79 ns |  0.461 ns |  0.274 ns |  0.41 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |    **5000** |  **7,319.33 ns** | **66.915 ns** | **39.820 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |    5000 |  2,868.97 ns | 29.228 ns | 19.333 ns |  0.39 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |   **10000** |  **2,971.12 ns** | **22.411 ns** | **14.824 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |   10000 |  1,153.23 ns |  7.346 ns |  4.859 ns |  0.39 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |   **50000** |  **8,651.53 ns** | **40.649 ns** | **24.190 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |   50000 |  3,374.37 ns | 15.152 ns | 10.022 ns |  0.39 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |  **100000** |  **4,651.84 ns** | **13.211 ns** |  **7.862 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |  100000 |  1,826.20 ns |  5.892 ns |  3.897 ns |  0.39 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** |  **500000** | **16,500.99 ns** | **91.953 ns** | **54.720 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster |  500000 |  6,756.84 ns | 34.199 ns | 22.621 ns |  0.41 |    0.00 |
|                      |         |              |           |           |       |         |
|   **FirstPredicateLinq** | **1000000** | **10,345.45 ns** | **39.945 ns** | **23.771 ns** |  **1.00** |    **0.00** |
| FirstPredicateFaster | 1000000 |  4,236.75 ns | 35.063 ns | 23.192 ns |  0.41 |    0.00 |

Benchmarks with issues:
  FirstPredicateBenchmark.FirstPredicateLinq: Job-GMHRDE(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
  FirstPredicateBenchmark.FirstPredicateFaster: Job-GMHRDE(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
