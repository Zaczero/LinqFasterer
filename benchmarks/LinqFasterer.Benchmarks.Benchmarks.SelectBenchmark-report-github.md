``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|              Method |       N |             Mean |           Error |          StdDev | Ratio | RatioSD |
|-------------------- |-------- |-----------------:|----------------:|----------------:|------:|--------:|
|          **SelectLinq** |       **0** |        **18.909 ns** |       **0.1381 ns** |       **0.0913 ns** |  **1.00** |    **0.00** |
|        SelectFaster |       0 |        10.438 ns |       0.0935 ns |       0.0618 ns |  0.55 |    0.00 |
| SelectInPlaceFaster |       0 |         5.943 ns |       0.0680 ns |       0.0450 ns |  0.31 |    0.00 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |       **1** |        **40.415 ns** |       **0.2198 ns** |       **0.1308 ns** |  **1.00** |    **0.00** |
|        SelectFaster |       1 |        12.694 ns |       0.0840 ns |       0.0500 ns |  0.31 |    0.00 |
| SelectInPlaceFaster |       1 |         7.719 ns |       0.0587 ns |       0.0349 ns |  0.19 |    0.00 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |       **3** |        **42.854 ns** |       **0.1215 ns** |       **0.0635 ns** |  **1.00** |    **0.00** |
|        SelectFaster |       3 |        16.627 ns |       0.1751 ns |       0.1158 ns |  0.39 |    0.00 |
| SelectInPlaceFaster |       3 |        11.386 ns |       0.0601 ns |       0.0358 ns |  0.27 |    0.00 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |       **5** |        **47.021 ns** |       **0.5391 ns** |       **0.3566 ns** |  **1.00** |    **0.00** |
|        SelectFaster |       5 |        20.561 ns |       0.1201 ns |       0.0715 ns |  0.44 |    0.00 |
| SelectInPlaceFaster |       5 |        15.497 ns |       0.1262 ns |       0.0835 ns |  0.33 |    0.00 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |      **10** |        **60.826 ns** |       **0.5811 ns** |       **0.3458 ns** |  **1.00** |    **0.00** |
|        SelectFaster |      10 |        28.454 ns |       0.4255 ns |       0.2532 ns |  0.47 |    0.00 |
| SelectInPlaceFaster |      10 |        30.906 ns |       0.8038 ns |       0.5316 ns |  0.51 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |      **50** |       **136.055 ns** |       **1.1709 ns** |       **0.7745 ns** |  **1.00** |    **0.00** |
|        SelectFaster |      50 |        99.559 ns |       0.9204 ns |       0.6088 ns |  0.73 |    0.01 |
| SelectInPlaceFaster |      50 |        97.587 ns |       0.8465 ns |       0.5599 ns |  0.72 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |     **100** |       **228.738 ns** |       **1.1799 ns** |       **0.7804 ns** |  **1.00** |    **0.00** |
|        SelectFaster |     100 |       179.215 ns |       1.4779 ns |       0.9776 ns |  0.78 |    0.01 |
| SelectInPlaceFaster |     100 |       182.243 ns |       1.2871 ns |       0.8513 ns |  0.80 |    0.00 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |     **250** |       **505.089 ns** |       **3.8926 ns** |       **2.3164 ns** |  **1.00** |    **0.00** |
|        SelectFaster |     250 |       416.821 ns |       5.5067 ns |       3.6423 ns |  0.83 |    0.01 |
| SelectInPlaceFaster |     250 |       436.528 ns |       3.7570 ns |       2.4850 ns |  0.86 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |     **500** |       **956.875 ns** |       **7.9361 ns** |       **5.2492 ns** |  **1.00** |    **0.00** |
|        SelectFaster |     500 |       855.101 ns |      25.4309 ns |      15.1335 ns |  0.89 |    0.02 |
| SelectInPlaceFaster |     500 |       891.084 ns |       3.5485 ns |       2.3471 ns |  0.93 |    0.00 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |    **1000** |     **1,946.168 ns** |      **18.4313 ns** |      **12.1911 ns** |  **1.00** |    **0.00** |
|        SelectFaster |    1000 |     1,675.529 ns |      12.0288 ns |       7.1582 ns |  0.86 |    0.01 |
| SelectInPlaceFaster |    1000 |     1,714.180 ns |      14.1446 ns |       9.3557 ns |  0.88 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |    **1500** |     **2,798.319 ns** |      **17.7569 ns** |      **11.7451 ns** |  **1.00** |    **0.00** |
|        SelectFaster |    1500 |     2,419.277 ns |      10.9926 ns |       7.2709 ns |  0.86 |    0.00 |
| SelectInPlaceFaster |    1500 |     2,569.679 ns |      16.4402 ns |      10.8742 ns |  0.92 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |    **2000** |     **3,726.947 ns** |      **24.7161 ns** |      **14.7082 ns** |  **1.00** |    **0.00** |
|        SelectFaster |    2000 |     3,204.200 ns |      34.1116 ns |      22.5627 ns |  0.86 |    0.01 |
| SelectInPlaceFaster |    2000 |     3,404.600 ns |      30.9003 ns |      20.4386 ns |  0.91 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |    **2500** |     **4,625.157 ns** |      **69.5419 ns** |      **45.9977 ns** |  **1.00** |    **0.00** |
|        SelectFaster |    2500 |     3,981.915 ns |      43.5820 ns |      28.8268 ns |  0.86 |    0.01 |
| SelectInPlaceFaster |    2500 |     4,261.352 ns |      43.1590 ns |      28.5470 ns |  0.92 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |    **3000** |     **5,565.691 ns** |      **37.2936 ns** |      **22.1928 ns** |  **1.00** |    **0.00** |
|        SelectFaster |    3000 |     4,835.575 ns |      39.2593 ns |      25.9676 ns |  0.87 |    0.00 |
| SelectInPlaceFaster |    3000 |     5,128.819 ns |      39.6597 ns |      26.2324 ns |  0.92 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |    **5000** |     **9,153.853 ns** |      **84.0271 ns** |      **55.5787 ns** |  **1.00** |    **0.00** |
|        SelectFaster |    5000 |     7,928.855 ns |     115.6770 ns |      76.5132 ns |  0.87 |    0.01 |
| SelectInPlaceFaster |    5000 |     8,473.264 ns |      70.9659 ns |      46.9396 ns |  0.93 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |   **10000** |    **18,397.701 ns** |     **155.7153 ns** |     **102.9961 ns** |  **1.00** |    **0.00** |
|        SelectFaster |   10000 |    15,784.510 ns |     206.3397 ns |     136.4809 ns |  0.86 |    0.01 |
| SelectInPlaceFaster |   10000 |    17,045.597 ns |     197.5784 ns |     130.6859 ns |  0.93 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |   **50000** |    **94,163.666 ns** |   **1,830.8740 ns** |   **1,211.0098 ns** |  **1.00** |    **0.00** |
|        SelectFaster |   50000 |    81,263.464 ns |     738.0381 ns |     488.1665 ns |  0.86 |    0.01 |
| SelectInPlaceFaster |   50000 |    84,614.390 ns |     777.9410 ns |     514.5598 ns |  0.90 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |  **100000** |   **207,655.183 ns** |   **1,894.9878 ns** |   **1,253.4171 ns** |  **1.00** |    **0.00** |
|        SelectFaster |  100000 |   181,410.479 ns |   2,376.2402 ns |   1,571.7358 ns |  0.87 |    0.01 |
| SelectInPlaceFaster |  100000 |   170,717.556 ns |   1,915.4972 ns |   1,266.9828 ns |  0.82 |    0.01 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** |  **500000** | **1,285,579.590 ns** |  **59,692.9208 ns** |  **39,483.1712 ns** |  **1.00** |    **0.00** |
|        SelectFaster |  500000 | 1,177,617.793 ns |  61,120.1200 ns |  40,427.1751 ns |  0.92 |    0.05 |
| SelectInPlaceFaster |  500000 |   965,461.611 ns |   8,829.9137 ns |   5,840.4412 ns |  0.75 |    0.02 |
|                     |         |                  |                 |                 |       |         |
|          **SelectLinq** | **1000000** | **3,003,205.703 ns** | **523,829.7686 ns** | **346,480.9584 ns** |  **1.00** |    **0.00** |
|        SelectFaster | 1000000 | 2,721,666.602 ns | 317,395.1107 ns | 209,937.2139 ns |  0.92 |    0.11 |
| SelectInPlaceFaster | 1000000 | 1,703,330.273 ns |  16,717.3656 ns |   9,948.2361 ns |  0.58 |    0.07 |
