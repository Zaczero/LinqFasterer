``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|                 Method |       N |             Mean |          Error |         StdDev | Ratio |
|----------------------- |-------- |-----------------:|---------------:|---------------:|------:|
|   **ContainsComparerLinq** |       **0** |         **7.718 ns** |      **0.0346 ns** |      **0.0206 ns** |  **1.00** |
| ContainsComparerFaster |       0 |         5.052 ns |      0.0330 ns |      0.0218 ns |  0.65 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |       **1** |        **17.533 ns** |      **0.1581 ns** |      **0.0941 ns** |  **1.00** |
| ContainsComparerFaster |       1 |         7.331 ns |      0.0172 ns |      0.0090 ns |  0.42 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |       **3** |        **29.349 ns** |      **0.2747 ns** |      **0.1817 ns** |  **1.00** |
| ContainsComparerFaster |       3 |        10.599 ns |      0.1931 ns |      0.1277 ns |  0.36 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |       **5** |        **50.771 ns** |      **0.5584 ns** |      **0.3693 ns** |  **1.00** |
| ContainsComparerFaster |       5 |        15.548 ns |      0.3080 ns |      0.2037 ns |  0.31 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |      **10** |        **72.989 ns** |      **0.4107 ns** |      **0.2148 ns** |  **1.00** |
| ContainsComparerFaster |      10 |        32.227 ns |      0.2888 ns |      0.1911 ns |  0.44 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |      **50** |       **289.519 ns** |      **2.0040 ns** |      **1.3255 ns** |  **1.00** |
| ContainsComparerFaster |      50 |       108.210 ns |      0.5861 ns |      0.3877 ns |  0.37 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |     **100** |       **559.156 ns** |      **3.4959 ns** |      **2.3124 ns** |  **1.00** |
| ContainsComparerFaster |     100 |       204.801 ns |      1.2263 ns |      0.8111 ns |  0.37 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |     **250** |     **1,363.930 ns** |     **10.1592 ns** |      **6.7197 ns** |  **1.00** |
| ContainsComparerFaster |     250 |       497.782 ns |      2.1574 ns |      1.2838 ns |  0.36 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |     **500** |     **2,729.531 ns** |     **32.4269 ns** |     **21.4484 ns** |  **1.00** |
| ContainsComparerFaster |     500 |       986.804 ns |      8.2306 ns |      4.8979 ns |  0.36 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |    **1000** |     **5,395.668 ns** |     **39.0516 ns** |     **25.8302 ns** |  **1.00** |
| ContainsComparerFaster |    1000 |     1,992.799 ns |     47.3224 ns |     28.1608 ns |  0.37 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |    **1500** |     **8,305.904 ns** |    **153.0285 ns** |    **101.2189 ns** |  **1.00** |
| ContainsComparerFaster |    1500 |     2,957.650 ns |     36.3903 ns |     21.6553 ns |  0.36 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |    **2000** |    **10,266.709 ns** |     **62.2427 ns** |     **41.1697 ns** |  **1.00** |
| ContainsComparerFaster |    2000 |     3,922.002 ns |     35.5586 ns |     23.5198 ns |  0.38 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |    **2500** |    **12,837.888 ns** |    **115.2434 ns** |     **76.2263 ns** |  **1.00** |
| ContainsComparerFaster |    2500 |     4,878.109 ns |     57.2613 ns |     37.8748 ns |  0.38 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |    **3000** |    **15,343.994 ns** |    **160.2584 ns** |    **106.0010 ns** |  **1.00** |
| ContainsComparerFaster |    3000 |     6,021.989 ns |    292.9930 ns |    174.3554 ns |  0.39 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |    **5000** |    **25,947.477 ns** |    **319.7954 ns** |    **190.3051 ns** |  **1.00** |
| ContainsComparerFaster |    5000 |     9,899.500 ns |    295.7368 ns |    195.6116 ns |  0.38 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |   **10000** |    **51,381.219 ns** |    **434.1172 ns** |    **287.1416 ns** |  **1.00** |
| ContainsComparerFaster |   10000 |    19,494.657 ns |    344.1770 ns |    204.8142 ns |  0.38 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |   **50000** |   **258,297.314 ns** |  **1,287.3767 ns** |    **851.5200 ns** |  **1.00** |
| ContainsComparerFaster |   50000 |    97,901.752 ns |    423.7492 ns |    280.2838 ns |  0.38 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |  **100000** |   **521,192.998 ns** | **11,267.7596 ns** |  **7,452.9253 ns** |  **1.00** |
| ContainsComparerFaster |  100000 |   195,366.542 ns |  1,171.6346 ns |    697.2209 ns |  0.37 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** |  **500000** | **2,568,621.406 ns** | **24,217.4212 ns** | **16,018.3247 ns** |  **1.00** |
| ContainsComparerFaster |  500000 |   982,894.590 ns |  7,025.2549 ns |  4,646.7712 ns |  0.38 |
|                        |         |                  |                |                |       |
|   **ContainsComparerLinq** | **1000000** | **5,148,322.031 ns** | **46,508.8756 ns** | **30,762.7416 ns** |  **1.00** |
| ContainsComparerFaster | 1000000 | 1,962,170.664 ns |  9,662.2151 ns |  6,390.9570 ns |  0.38 |
