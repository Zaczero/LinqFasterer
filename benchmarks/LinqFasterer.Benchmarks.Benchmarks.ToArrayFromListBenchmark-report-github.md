``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|                Method |       N |            Mean |          Error |         StdDev | Ratio | RatioSD |
|---------------------- |-------- |----------------:|---------------:|---------------:|------:|--------:|
|   **ToArrayFromListLinq** |       **0** |        **26.22 ns** |       **0.297 ns** |       **0.197 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |       0 |        44.92 ns |       0.343 ns |       0.204 ns |  1.71 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |       **1** |        **50.03 ns** |       **0.335 ns** |       **0.221 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |       1 |        58.54 ns |       1.073 ns |       0.710 ns |  1.17 |    0.02 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |       **3** |        **47.54 ns** |       **0.186 ns** |       **0.123 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |       3 |        53.09 ns |       0.475 ns |       0.314 ns |  1.12 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |       **5** |        **48.48 ns** |       **0.239 ns** |       **0.158 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |       5 |        54.76 ns |       0.524 ns |       0.312 ns |  1.13 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |      **10** |        **48.94 ns** |       **0.269 ns** |       **0.178 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |      10 |        59.35 ns |       0.589 ns |       0.389 ns |  1.21 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |      **50** |        **60.85 ns** |       **0.552 ns** |       **0.365 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |      50 |        68.90 ns |       0.599 ns |       0.396 ns |  1.13 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |     **100** |        **82.24 ns** |       **0.728 ns** |       **0.433 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |     100 |        91.22 ns |       2.196 ns |       1.307 ns |  1.11 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |     **250** |       **144.00 ns** |       **1.596 ns** |       **0.950 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |     250 |       148.55 ns |       1.819 ns |       1.082 ns |  1.03 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |     **500** |       **253.77 ns** |       **3.216 ns** |       **2.127 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |     500 |       257.38 ns |       2.615 ns |       1.556 ns |  1.02 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |    **1000** |       **448.70 ns** |       **6.734 ns** |       **4.008 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |    1000 |       461.87 ns |       3.331 ns |       1.742 ns |  1.03 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |    **1500** |       **679.98 ns** |      **11.198 ns** |       **6.663 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |    1500 |       680.02 ns |       3.379 ns |       1.767 ns |  1.00 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |    **2000** |       **871.59 ns** |       **8.881 ns** |       **5.285 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |    2000 |       873.66 ns |       9.997 ns |       6.612 ns |  1.00 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |    **2500** |     **1,038.05 ns** |      **38.970 ns** |      **25.776 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |    2500 |     1,081.77 ns |      43.241 ns |      25.732 ns |  1.04 |    0.05 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |    **3000** |     **1,219.94 ns** |      **44.485 ns** |      **29.424 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |    3000 |     1,209.34 ns |       6.126 ns |       4.052 ns |  0.99 |    0.02 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |    **5000** |     **2,020.02 ns** |      **66.637 ns** |      **39.655 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |    5000 |     2,074.06 ns |      14.961 ns |       8.903 ns |  1.03 |    0.02 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |   **10000** |     **3,757.26 ns** |      **56.136 ns** |      **33.406 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |   10000 |     3,802.42 ns |     127.004 ns |      84.005 ns |  1.02 |    0.02 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |   **50000** |    **23,468.55 ns** |     **399.736 ns** |     **264.400 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |   50000 |    23,575.19 ns |     233.463 ns |     154.421 ns |  1.00 |    0.01 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |  **100000** |    **78,953.92 ns** |   **5,075.651 ns** |   **3,357.229 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |  100000 |    77,216.72 ns |   2,565.552 ns |   1,696.954 ns |  0.98 |    0.04 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** |  **500000** | **1,305,624.84 ns** | **154,476.772 ns** | **102,176.820 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster |  500000 | 1,408,827.03 ns | 205,155.557 ns | 135,697.699 ns |  1.08 |    0.13 |
|                       |         |                 |                |                |       |         |
|   **ToArrayFromListLinq** | **1000000** | **3,394,450.74 ns** |  **76,335.393 ns** |  **50,491.136 ns** |  **1.00** |    **0.00** |
| ToArrayFromListFaster | 1000000 | 3,379,421.84 ns |  88,536.571 ns |  58,561.460 ns |  1.00 |    0.02 |
