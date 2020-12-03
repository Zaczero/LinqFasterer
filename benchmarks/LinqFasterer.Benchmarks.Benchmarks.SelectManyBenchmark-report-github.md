``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|           Method |       N |              Mean |            Error |           StdDev | Ratio |
|----------------- |-------- |------------------:|-----------------:|-----------------:|------:|
|   **SelectManyLinq** |       **0** |          **42.99 ns** |         **0.328 ns** |         **0.195 ns** |  **1.00** |
| SelectManyFaster |       0 |          34.10 ns |         0.260 ns |         0.155 ns |  0.79 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |       **1** |         **129.00 ns** |         **1.050 ns** |         **0.695 ns** |  **1.00** |
| SelectManyFaster |       1 |          59.58 ns |         0.812 ns |         0.537 ns |  0.46 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |       **3** |         **255.49 ns** |         **2.987 ns** |         **1.976 ns** |  **1.00** |
| SelectManyFaster |       3 |         122.84 ns |         1.265 ns |         0.836 ns |  0.48 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |       **5** |         **414.00 ns** |         **3.537 ns** |         **2.105 ns** |  **1.00** |
| SelectManyFaster |       5 |         151.00 ns |         1.320 ns |         0.873 ns |  0.36 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |      **10** |         **749.01 ns** |         **5.263 ns** |         **3.132 ns** |  **1.00** |
| SelectManyFaster |      10 |         264.54 ns |         1.473 ns |         0.974 ns |  0.35 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |      **50** |       **2,925.37 ns** |        **30.803 ns** |        **20.374 ns** |  **1.00** |
| SelectManyFaster |      50 |         940.82 ns |        12.620 ns |         6.600 ns |  0.32 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |     **100** |       **5,429.17 ns** |        **54.864 ns** |        **32.649 ns** |  **1.00** |
| SelectManyFaster |     100 |       1,702.33 ns |        22.238 ns |        11.631 ns |  0.31 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |     **250** |      **12,633.70 ns** |        **86.317 ns** |        **57.093 ns** |  **1.00** |
| SelectManyFaster |     250 |       3,776.07 ns |        67.177 ns |        39.976 ns |  0.30 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |     **500** |      **24,762.75 ns** |       **240.164 ns** |       **158.853 ns** |  **1.00** |
| SelectManyFaster |     500 |       7,301.15 ns |        53.365 ns |        31.757 ns |  0.29 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |    **1000** |      **54,732.28 ns** |       **614.971 ns** |       **365.959 ns** |  **1.00** |
| SelectManyFaster |    1000 |      14,487.77 ns |       150.626 ns |        99.630 ns |  0.26 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |    **1500** |      **78,477.48 ns** |       **703.969 ns** |       **465.632 ns** |  **1.00** |
| SelectManyFaster |    1500 |      22,245.94 ns |       189.295 ns |       112.646 ns |  0.28 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |    **2000** |      **97,740.59 ns** |     **1,256.956 ns** |       **831.399 ns** |  **1.00** |
| SelectManyFaster |    2000 |      28,365.04 ns |       186.969 ns |       111.262 ns |  0.29 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |    **2500** |     **128,143.40 ns** |       **972.068 ns** |       **578.462 ns** |  **1.00** |
| SelectManyFaster |    2500 |      34,653.21 ns |       367.884 ns |       218.922 ns |  0.27 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |    **3000** |     **151,745.11 ns** |     **1,766.467 ns** |     **1,168.409 ns** |  **1.00** |
| SelectManyFaster |    3000 |      43,349.68 ns |       412.496 ns |       272.841 ns |  0.29 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |    **5000** |     **245,749.94 ns** |     **1,252.359 ns** |       **828.358 ns** |  **1.00** |
| SelectManyFaster |    5000 |      68,381.17 ns |       711.125 ns |       423.179 ns |  0.28 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |   **10000** |     **646,475.71 ns** |     **3,363.054 ns** |     **2,001.299 ns** |  **1.00** |
| SelectManyFaster |   10000 |     174,680.02 ns |     1,676.231 ns |     1,108.723 ns |  0.27 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |   **50000** |   **3,676,286.72 ns** |    **25,842.424 ns** |    **15,378.412 ns** |  **1.00** |
| SelectManyFaster |   50000 |   1,183,875.92 ns |    55,086.912 ns |    36,436.581 ns |  0.32 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |  **100000** |  **14,481,663.12 ns** |   **754,430.322 ns** |   **499,008.946 ns** |  **1.00** |
| SelectManyFaster |  100000 |   2,351,328.91 ns |    52,569.148 ns |    27,494.681 ns |  0.16 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** |  **500000** |  **56,617,476.00 ns** |   **968,700.359 ns** |   **640,735.309 ns** |  **1.00** |
| SelectManyFaster |  500000 |  15,918,673.75 ns |   108,417.306 ns |    71,711.335 ns |  0.28 |
|                  |         |                   |                  |                  |       |
|   **SelectManyLinq** | **1000000** | **117,329,876.00 ns** | **3,127,441.585 ns** | **2,068,608.970 ns** |  **1.00** |
| SelectManyFaster | 1000000 |  30,073,196.25 ns |   493,614.095 ns |   326,495.161 ns |  0.26 |
