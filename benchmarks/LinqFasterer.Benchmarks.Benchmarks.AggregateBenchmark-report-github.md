``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|          Method |       N |             Mean |          Error |         StdDev | Ratio | RatioSD |
|---------------- |-------- |-----------------:|---------------:|---------------:|------:|--------:|
|   **AggregateLinq** |       **0** |               **NA** |             **NA** |             **NA** |     **?** |       **?** |
| AggregateFaster |       0 |               NA |             NA |             NA |     ? |       ? |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |       **1** |        **15.720 ns** |      **0.2851 ns** |      **0.1886 ns** |  **1.00** |    **0.00** |
| AggregateFaster |       1 |         5.017 ns |      0.0541 ns |      0.0358 ns |  0.32 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |       **3** |        **25.980 ns** |      **0.2807 ns** |      **0.1857 ns** |  **1.00** |    **0.00** |
| AggregateFaster |       3 |         9.823 ns |      0.1346 ns |      0.0891 ns |  0.38 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |       **5** |        **36.434 ns** |      **0.9338 ns** |      **0.4884 ns** |  **1.00** |    **0.00** |
| AggregateFaster |       5 |        14.493 ns |      0.0780 ns |      0.0516 ns |  0.40 |    0.01 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |      **10** |        **67.661 ns** |      **0.7505 ns** |      **0.4964 ns** |  **1.00** |    **0.00** |
| AggregateFaster |      10 |        23.077 ns |      0.1212 ns |      0.0634 ns |  0.34 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |      **50** |       **262.644 ns** |      **3.1199 ns** |      **1.8566 ns** |  **1.00** |    **0.00** |
| AggregateFaster |      50 |        96.726 ns |      0.9220 ns |      0.6098 ns |  0.37 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |     **100** |       **507.826 ns** |      **4.8807 ns** |      **3.2282 ns** |  **1.00** |    **0.00** |
| AggregateFaster |     100 |       182.275 ns |      1.0783 ns |      0.6417 ns |  0.36 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |     **250** |     **1,244.242 ns** |      **7.6542 ns** |      **5.0628 ns** |  **1.00** |    **0.00** |
| AggregateFaster |     250 |       437.590 ns |      3.0233 ns |      1.7991 ns |  0.35 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |     **500** |     **2,474.417 ns** |     **18.1521 ns** |     **10.8020 ns** |  **1.00** |    **0.00** |
| AggregateFaster |     500 |       863.989 ns |      7.6276 ns |      5.0452 ns |  0.35 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |    **1000** |     **4,923.336 ns** |     **36.2637 ns** |     **21.5799 ns** |  **1.00** |    **0.00** |
| AggregateFaster |    1000 |     1,722.912 ns |      7.9107 ns |      5.2325 ns |  0.35 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |    **1500** |     **7,341.551 ns** |     **47.8864 ns** |     **28.4964 ns** |  **1.00** |    **0.00** |
| AggregateFaster |    1500 |     2,592.911 ns |     30.1569 ns |     17.9459 ns |  0.35 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |    **2000** |    **10,537.564 ns** |    **152.2366 ns** |    **100.6951 ns** |  **1.00** |    **0.00** |
| AggregateFaster |    2000 |     3,479.857 ns |     27.1643 ns |     16.1651 ns |  0.33 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |    **2500** |    **12,896.951 ns** |     **71.2370 ns** |     **47.1189 ns** |  **1.00** |    **0.00** |
| AggregateFaster |    2500 |     4,281.703 ns |      8.6572 ns |      5.1518 ns |  0.33 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |    **3000** |    **15,458.277 ns** |    **117.3032 ns** |     **69.8052 ns** |  **1.00** |    **0.00** |
| AggregateFaster |    3000 |     5,136.706 ns |     20.3649 ns |     12.1188 ns |  0.33 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |    **5000** |    **25,759.088 ns** |    **223.6426 ns** |    **147.9258 ns** |  **1.00** |    **0.00** |
| AggregateFaster |    5000 |     8,525.827 ns |     21.0236 ns |     12.5108 ns |  0.33 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |   **10000** |    **51,418.638 ns** |    **248.1482 ns** |    **164.1347 ns** |  **1.00** |    **0.00** |
| AggregateFaster |   10000 |    17,046.535 ns |    104.1276 ns |     68.8739 ns |  0.33 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |   **50000** |   **258,631.460 ns** |  **1,987.0708 ns** |  **1,314.3243 ns** |  **1.00** |    **0.00** |
| AggregateFaster |   50000 |    85,210.271 ns |  1,117.0993 ns |    738.8920 ns |  0.33 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |  **100000** |   **516,006.689 ns** |  **2,879.1585 ns** |  **1,904.3851 ns** |  **1.00** |    **0.00** |
| AggregateFaster |  100000 |   170,933.877 ns |  1,249.5162 ns |    826.4776 ns |  0.33 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** |  **500000** | **2,579,388.359 ns** | **18,203.2732 ns** | **12,040.3382 ns** |  **1.00** |    **0.00** |
| AggregateFaster |  500000 |   853,238.737 ns |  3,553.1815 ns |  2,114.4413 ns |  0.33 |    0.00 |
|                 |         |                  |                |                |       |         |
|   **AggregateLinq** | **1000000** | **5,163,428.082 ns** | **35,676.9864 ns** | **21,230.8023 ns** |  **1.00** |    **0.00** |
| AggregateFaster | 1000000 | 1,702,652.539 ns | 11,638.0708 ns |  7,697.8632 ns |  0.33 |    0.00 |

Benchmarks with issues:
  AggregateBenchmark.AggregateLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
  AggregateBenchmark.AggregateFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
