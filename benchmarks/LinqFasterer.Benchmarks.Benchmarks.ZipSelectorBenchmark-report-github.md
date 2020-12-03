``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|            Method |       N |             Mean |          Error |         StdDev | Ratio |
|------------------ |-------- |-----------------:|---------------:|---------------:|------:|
|   **ZipSelectorLinq** |       **0** |        **113.78 ns** |       **0.831 ns** |       **0.550 ns** |  **1.00** |
| ZipSelectorFaster |       0 |         61.73 ns |       0.527 ns |       0.348 ns |  0.54 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |       **1** |        **223.41 ns** |       **0.955 ns** |       **0.632 ns** |  **1.00** |
| ZipSelectorFaster |       1 |         68.53 ns |       0.486 ns |       0.321 ns |  0.31 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |       **3** |        **272.91 ns** |       **2.921 ns** |       **1.932 ns** |  **1.00** |
| ZipSelectorFaster |       3 |         73.58 ns |       0.680 ns |       0.450 ns |  0.27 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |       **5** |        **328.47 ns** |       **1.991 ns** |       **1.185 ns** |  **1.00** |
| ZipSelectorFaster |       5 |         78.33 ns |       0.869 ns |       0.517 ns |  0.24 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |      **10** |        **467.91 ns** |       **5.243 ns** |       **3.120 ns** |  **1.00** |
| ZipSelectorFaster |      10 |        100.35 ns |       0.270 ns |       0.161 ns |  0.21 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |      **50** |      **1,283.92 ns** |       **6.289 ns** |       **4.160 ns** |  **1.00** |
| ZipSelectorFaster |      50 |        186.13 ns |       2.070 ns |       1.369 ns |  0.14 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |     **100** |      **2,196.09 ns** |      **15.061 ns** |       **8.962 ns** |  **1.00** |
| ZipSelectorFaster |     100 |        305.10 ns |       2.312 ns |       1.529 ns |  0.14 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |     **250** |      **4,933.50 ns** |     **149.847 ns** |      **99.115 ns** |  **1.00** |
| ZipSelectorFaster |     250 |        642.48 ns |       5.787 ns |       3.444 ns |  0.13 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |     **500** |      **9,526.98 ns** |      **85.535 ns** |      **56.576 ns** |  **1.00** |
| ZipSelectorFaster |     500 |      1,223.20 ns |      13.851 ns |       9.161 ns |  0.13 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |    **1000** |     **18,512.96 ns** |     **183.186 ns** |     **121.166 ns** |  **1.00** |
| ZipSelectorFaster |    1000 |      2,361.97 ns |      17.570 ns |      11.621 ns |  0.13 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |    **1500** |     **27,480.20 ns** |     **203.218 ns** |     **120.932 ns** |  **1.00** |
| ZipSelectorFaster |    1500 |      3,507.36 ns |      45.096 ns |      29.829 ns |  0.13 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |    **2000** |     **36,444.19 ns** |     **451.326 ns** |     **268.577 ns** |  **1.00** |
| ZipSelectorFaster |    2000 |      4,632.65 ns |      21.740 ns |      12.937 ns |  0.13 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |    **2500** |     **46,079.45 ns** |   **1,299.612 ns** |     **859.613 ns** |  **1.00** |
| ZipSelectorFaster |    2500 |      5,711.50 ns |      51.605 ns |      34.133 ns |  0.12 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |    **3000** |     **55,037.65 ns** |   **1,431.435 ns** |     **946.806 ns** |  **1.00** |
| ZipSelectorFaster |    3000 |      6,791.88 ns |      80.610 ns |      53.319 ns |  0.12 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |    **5000** |     **90,219.57 ns** |     **529.917 ns** |     **315.345 ns** |  **1.00** |
| ZipSelectorFaster |    5000 |     11,254.96 ns |      93.745 ns |      55.786 ns |  0.12 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |   **10000** |    **179,008.39 ns** |   **1,846.341 ns** |   **1,221.240 ns** |  **1.00** |
| ZipSelectorFaster |   10000 |     22,223.40 ns |     166.767 ns |      99.241 ns |  0.12 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |   **50000** |    **904,506.40 ns** |   **5,450.973 ns** |   **2,850.964 ns** |  **1.00** |
| ZipSelectorFaster |   50000 |    135,338.90 ns |   1,758.048 ns |   1,162.840 ns |  0.15 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |  **100000** |  **1,855,489.65 ns** |   **8,676.141 ns** |   **5,163.032 ns** |  **1.00** |
| ZipSelectorFaster |  100000 |    318,767.92 ns |   3,711.515 ns |   2,454.937 ns |  0.17 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** |  **500000** |  **9,651,786.88 ns** | **205,230.267 ns** | **135,747.114 ns** |  **1.00** |
| ZipSelectorFaster |  500000 |  2,749,793.05 ns |  61,840.100 ns |  40,903.398 ns |  0.28 |
|                   |         |                  |                |                |       |
|   **ZipSelectorLinq** | **1000000** | **19,282,450.31 ns** | **209,378.333 ns** | **138,490.803 ns** |  **1.00** |
| ZipSelectorFaster | 1000000 |  5,564,007.66 ns |  68,739.052 ns |  45,466.627 ns |  0.29 |
