``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|      Method |       N |            Mean |          Error |        StdDev | Ratio | RatioSD |
|------------ |-------- |----------------:|---------------:|--------------:|------:|--------:|
|   **WhereLinq** |       **0** |        **13.12 ns** |       **0.194 ns** |      **0.128 ns** |  **1.00** |    **0.00** |
| WhereFaster |       0 |        12.07 ns |       0.170 ns |      0.113 ns |  0.92 |    0.01 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |       **1** |        **57.98 ns** |       **0.457 ns** |      **0.302 ns** |  **1.00** |    **0.00** |
| WhereFaster |       1 |        13.20 ns |       0.116 ns |      0.077 ns |  0.23 |    0.00 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |       **3** |        **62.37 ns** |       **0.665 ns** |      **0.440 ns** |  **1.00** |    **0.00** |
| WhereFaster |       3 |        18.27 ns |       0.187 ns |      0.123 ns |  0.29 |    0.00 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |       **5** |        **84.86 ns** |       **0.527 ns** |      **0.314 ns** |  **1.00** |    **0.00** |
| WhereFaster |       5 |        22.28 ns |       0.139 ns |      0.092 ns |  0.26 |    0.00 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |      **10** |       **127.94 ns** |       **1.598 ns** |      **1.057 ns** |  **1.00** |    **0.00** |
| WhereFaster |      10 |        32.08 ns |       0.277 ns |      0.183 ns |  0.25 |    0.00 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |      **50** |       **320.85 ns** |       **1.953 ns** |      **1.292 ns** |  **1.00** |    **0.00** |
| WhereFaster |      50 |       126.17 ns |       0.586 ns |      0.387 ns |  0.39 |    0.00 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |     **100** |       **507.85 ns** |       **6.119 ns** |      **4.047 ns** |  **1.00** |    **0.00** |
| WhereFaster |     100 |       237.42 ns |       2.147 ns |      1.420 ns |  0.47 |    0.01 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |     **250** |       **969.55 ns** |      **17.700 ns** |     **11.708 ns** |  **1.00** |    **0.00** |
| WhereFaster |     250 |       564.86 ns |       7.566 ns |      5.004 ns |  0.58 |    0.01 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |     **500** |     **1,648.52 ns** |      **14.733 ns** |      **8.768 ns** |  **1.00** |    **0.00** |
| WhereFaster |     500 |     1,115.54 ns |       6.742 ns |      4.459 ns |  0.68 |    0.00 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |    **1000** |     **3,126.54 ns** |      **40.825 ns** |     **27.003 ns** |  **1.00** |    **0.00** |
| WhereFaster |    1000 |     2,199.10 ns |      18.613 ns |     11.076 ns |  0.70 |    0.01 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |    **1500** |     **4,425.31 ns** |      **41.053 ns** |     **24.430 ns** |  **1.00** |    **0.00** |
| WhereFaster |    1500 |     3,308.85 ns |      19.241 ns |     12.727 ns |  0.75 |    0.01 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |    **2000** |     **5,785.72 ns** |     **240.972 ns** |    **159.388 ns** |  **1.00** |    **0.00** |
| WhereFaster |    2000 |     4,389.52 ns |      31.158 ns |     18.542 ns |  0.76 |    0.02 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |    **2500** |     **6,997.50 ns** |      **85.195 ns** |     **50.698 ns** |  **1.00** |    **0.00** |
| WhereFaster |    2500 |     5,522.11 ns |      30.593 ns |     20.235 ns |  0.79 |    0.01 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |    **3000** |     **8,574.49 ns** |     **170.425 ns** |    **112.725 ns** |  **1.00** |    **0.00** |
| WhereFaster |    3000 |     6,609.13 ns |      30.529 ns |     18.167 ns |  0.77 |    0.01 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |    **5000** |    **13,685.95 ns** |     **166.677 ns** |     **87.175 ns** |  **1.00** |    **0.00** |
| WhereFaster |    5000 |    11,014.77 ns |     105.651 ns |     69.881 ns |  0.81 |    0.01 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |   **10000** |    **27,942.48 ns** |     **345.028 ns** |    **180.456 ns** |  **1.00** |    **0.00** |
| WhereFaster |   10000 |    22,009.04 ns |     108.925 ns |     72.047 ns |  0.79 |    0.00 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |   **50000** |   **149,999.51 ns** |   **4,996.604 ns** |  **3,304.944 ns** |  **1.00** |    **0.00** |
| WhereFaster |   50000 |   109,142.27 ns |   1,215.003 ns |    803.649 ns |  0.73 |    0.02 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |  **100000** |   **308,898.19 ns** |   **3,708.690 ns** |  **2,453.069 ns** |  **1.00** |    **0.00** |
| WhereFaster |  100000 |   219,699.00 ns |   1,711.647 ns |  1,132.149 ns |  0.71 |    0.01 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** |  **500000** | **2,407,019.30 ns** |  **50,028.708 ns** | **33,090.893 ns** |  **1.00** |    **0.00** |
| WhereFaster |  500000 | 1,107,577.34 ns |   5,848.457 ns |  3,868.392 ns |  0.46 |    0.01 |
|             |         |                 |                |               |       |         |
|   **WhereLinq** | **1000000** | **4,256,848.48 ns** | **145,488.182 ns** | **86,577.683 ns** |  **1.00** |    **0.00** |
| WhereFaster | 1000000 | 2,208,046.84 ns |  21,435.991 ns | 14,178.581 ns |  0.52 |    0.01 |
