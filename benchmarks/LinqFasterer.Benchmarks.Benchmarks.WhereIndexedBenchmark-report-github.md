``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|             Method |       N |             Mean |         Error |        StdDev | Ratio |
|------------------- |-------- |-----------------:|--------------:|--------------:|------:|
|   **WhereIndexedLinq** |       **0** |         **67.41 ns** |      **0.807 ns** |      **0.534 ns** |  **1.00** |
| WhereIndexedFaster |       0 |         12.08 ns |      0.138 ns |      0.091 ns |  0.18 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |       **1** |        **120.71 ns** |      **2.235 ns** |      **1.479 ns** |  **1.00** |
| WhereIndexedFaster |       1 |         13.44 ns |      0.117 ns |      0.077 ns |  0.11 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |       **3** |        **138.30 ns** |      **1.298 ns** |      **0.859 ns** |  **1.00** |
| WhereIndexedFaster |       3 |         18.26 ns |      0.110 ns |      0.073 ns |  0.13 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |       **5** |        **188.26 ns** |      **1.494 ns** |      **0.889 ns** |  **1.00** |
| WhereIndexedFaster |       5 |         22.35 ns |      0.216 ns |      0.143 ns |  0.12 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |      **10** |        **283.56 ns** |      **3.567 ns** |      **2.123 ns** |  **1.00** |
| WhereIndexedFaster |      10 |         32.03 ns |      0.414 ns |      0.274 ns |  0.11 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |      **50** |        **855.91 ns** |      **8.141 ns** |      **5.385 ns** |  **1.00** |
| WhereIndexedFaster |      50 |        126.28 ns |      1.845 ns |      1.220 ns |  0.15 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |     **100** |      **1,451.62 ns** |     **16.356 ns** |     **10.819 ns** |  **1.00** |
| WhereIndexedFaster |     100 |        235.29 ns |      2.597 ns |      1.718 ns |  0.16 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |     **250** |      **3,204.40 ns** |     **26.875 ns** |     **17.776 ns** |  **1.00** |
| WhereIndexedFaster |     250 |        566.78 ns |     11.790 ns |      7.798 ns |  0.18 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |     **500** |      **6,132.54 ns** |     **47.701 ns** |     **31.551 ns** |  **1.00** |
| WhereIndexedFaster |     500 |      1,104.60 ns |     14.040 ns |      9.286 ns |  0.18 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |    **1000** |     **11,917.57 ns** |     **75.853 ns** |     **50.172 ns** |  **1.00** |
| WhereIndexedFaster |    1000 |      2,208.14 ns |     32.592 ns |     21.558 ns |  0.19 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |    **1500** |     **17,714.43 ns** |    **191.557 ns** |    **126.703 ns** |  **1.00** |
| WhereIndexedFaster |    1500 |      3,295.62 ns |     33.318 ns |     19.827 ns |  0.19 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |    **2000** |     **23,429.07 ns** |    **174.770 ns** |    **115.599 ns** |  **1.00** |
| WhereIndexedFaster |    2000 |      4,374.53 ns |     44.796 ns |     29.630 ns |  0.19 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |    **2500** |     **29,440.70 ns** |    **462.109 ns** |    **305.657 ns** |  **1.00** |
| WhereIndexedFaster |    2500 |      5,500.88 ns |     20.112 ns |     11.968 ns |  0.19 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |    **3000** |     **34,914.60 ns** |    **537.943 ns** |    **355.816 ns** |  **1.00** |
| WhereIndexedFaster |    3000 |      6,551.11 ns |     70.326 ns |     46.516 ns |  0.19 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |    **5000** |     **58,586.26 ns** |    **669.420 ns** |    **442.780 ns** |  **1.00** |
| WhereIndexedFaster |    5000 |     10,876.27 ns |     99.499 ns |     65.813 ns |  0.19 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |   **10000** |    **115,775.52 ns** |    **811.643 ns** |    **482.996 ns** |  **1.00** |
| WhereIndexedFaster |   10000 |     21,904.88 ns |    124.753 ns |     82.516 ns |  0.19 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |   **50000** |    **602,319.38 ns** |  **6,055.684 ns** |  **4,005.460 ns** |  **1.00** |
| WhereIndexedFaster |   50000 |    109,978.53 ns |    865.044 ns |    572.173 ns |  0.18 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |  **100000** |  **1,204,744.34 ns** |  **9,484.715 ns** |  **6,273.551 ns** |  **1.00** |
| WhereIndexedFaster |  100000 |    218,012.61 ns |  1,049.233 ns |    624.382 ns |  0.18 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** |  **500000** |  **6,437,096.53 ns** | **40,518.087 ns** | **24,111.663 ns** |  **1.00** |
| WhereIndexedFaster |  500000 |  1,113,576.25 ns | 14,083.752 ns |  9,315.530 ns |  0.17 |
|                    |         |                  |               |               |       |
|   **WhereIndexedLinq** | **1000000** | **13,164,956.60 ns** | **91,535.067 ns** | **54,471.050 ns** |  **1.00** |
| WhereIndexedFaster | 1000000 |  2,257,450.70 ns | 18,443.023 ns | 12,198.918 ns |  0.17 |
