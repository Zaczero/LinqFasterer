``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|               Method |       N |             Mean |           Error |         StdDev | Ratio |
|--------------------- |-------- |-----------------:|----------------:|---------------:|------:|
|   **CountPredicateLinq** |       **0** |         **7.470 ns** |       **0.0540 ns** |      **0.0321 ns** |  **1.00** |
| CountPredicateFaster |       0 |         8.226 ns |       0.0662 ns |      0.0438 ns |  1.10 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |       **1** |        **18.024 ns** |       **0.1046 ns** |      **0.0622 ns** |  **1.00** |
| CountPredicateFaster |       1 |         9.993 ns |       0.0582 ns |      0.0346 ns |  0.55 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |       **3** |        **27.914 ns** |       **0.0678 ns** |      **0.0354 ns** |  **1.00** |
| CountPredicateFaster |       3 |        14.670 ns |       0.1818 ns |      0.1203 ns |  0.53 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |       **5** |        **39.536 ns** |       **0.4650 ns** |      **0.3076 ns** |  **1.00** |
| CountPredicateFaster |       5 |        18.326 ns |       0.1373 ns |      0.0908 ns |  0.46 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |      **10** |        **77.295 ns** |       **0.8546 ns** |      **0.5086 ns** |  **1.00** |
| CountPredicateFaster |      10 |        28.536 ns |       0.2517 ns |      0.1498 ns |  0.37 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |      **50** |       **466.689 ns** |       **6.5650 ns** |      **4.3424 ns** |  **1.00** |
| CountPredicateFaster |      50 |       137.180 ns |       1.0411 ns |      0.6886 ns |  0.29 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |     **100** |       **884.037 ns** |       **7.2746 ns** |      **4.3290 ns** |  **1.00** |
| CountPredicateFaster |     100 |       350.431 ns |       2.4889 ns |      1.4811 ns |  0.40 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |     **250** |     **2,236.052 ns** |      **24.4532 ns** |     **16.1743 ns** |  **1.00** |
| CountPredicateFaster |     250 |     1,001.348 ns |       6.0230 ns |      3.1502 ns |  0.45 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |     **500** |     **4,354.912 ns** |      **57.2106 ns** |     **37.8412 ns** |  **1.00** |
| CountPredicateFaster |     500 |     2,231.454 ns |      22.9770 ns |     15.1979 ns |  0.51 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |    **1000** |     **8,654.196 ns** |      **92.1706 ns** |     **60.9652 ns** |  **1.00** |
| CountPredicateFaster |    1000 |     4,653.799 ns |      30.2901 ns |     20.0350 ns |  0.54 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |    **1500** |    **12,961.564 ns** |     **106.9692 ns** |     **70.7535 ns** |  **1.00** |
| CountPredicateFaster |    1500 |     7,076.102 ns |      23.0751 ns |     13.7316 ns |  0.55 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |    **2000** |    **17,464.943 ns** |     **179.8037 ns** |    **118.9290 ns** |  **1.00** |
| CountPredicateFaster |    2000 |     9,578.660 ns |      23.5347 ns |     14.0051 ns |  0.55 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |    **2500** |    **21,740.801 ns** |     **125.4668 ns** |     **74.6633 ns** |  **1.00** |
| CountPredicateFaster |    2500 |    11,944.966 ns |      34.4216 ns |     22.7678 ns |  0.55 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |    **3000** |    **26,297.670 ns** |     **201.8730 ns** |    **133.5265 ns** |  **1.00** |
| CountPredicateFaster |    3000 |    14,308.892 ns |     115.2946 ns |     76.2603 ns |  0.54 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |    **5000** |    **43,503.107 ns** |     **365.8666 ns** |    **241.9981 ns** |  **1.00** |
| CountPredicateFaster |    5000 |    24,289.363 ns |     212.4957 ns |    111.1393 ns |  0.56 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |   **10000** |    **86,976.282 ns** |   **1,274.5612 ns** |    **843.0433 ns** |  **1.00** |
| CountPredicateFaster |   10000 |    48,282.123 ns |     233.0799 ns |    138.7021 ns |  0.56 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |   **50000** |   **436,699.585 ns** |   **5,407.1386 ns** |  **3,576.4874 ns** |  **1.00** |
| CountPredicateFaster |   50000 |   242,245.557 ns |   1,689.4399 ns |  1,117.4599 ns |  0.55 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |  **100000** |   **863,023.231 ns** |   **4,715.1313 ns** |  **2,805.8990 ns** |  **1.00** |
| CountPredicateFaster |  100000 |   483,430.264 ns |   4,011.4270 ns |  2,653.3106 ns |  0.56 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** |  **500000** | **4,536,165.469 ns** |  **59,065.3548 ns** | **39,068.0751 ns** |  **1.00** |
| CountPredicateFaster |  500000 | 2,425,447.578 ns |  12,308.1798 ns |  8,141.0989 ns |  0.53 |
|                      |         |                  |                 |                |       |
|   **CountPredicateLinq** | **1000000** | **8,982,626.562 ns** | **119,762.1762 ns** | **79,215.2644 ns** |  **1.00** |
| CountPredicateFaster | 1000000 | 4,860,761.458 ns |  40,078.7026 ns | 23,850.1930 ns |  0.54 |
