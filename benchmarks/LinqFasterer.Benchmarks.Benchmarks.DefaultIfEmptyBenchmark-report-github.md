``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|               Method |       N |             Mean |          Error |         StdDev | Ratio |
|--------------------- |-------- |-----------------:|---------------:|---------------:|------:|
|   **DefaultIfEmptyLinq** |       **0** |        **41.856 ns** |      **0.5284 ns** |      **0.3495 ns** |  **1.00** |
| DefaultIfEmptyFaster |       0 |         8.394 ns |      0.1067 ns |      0.0706 ns |  0.20 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |       **1** |        **48.741 ns** |      **0.5438 ns** |      **0.3597 ns** |  **1.00** |
| DefaultIfEmptyFaster |       1 |         5.767 ns |      0.0658 ns |      0.0436 ns |  0.12 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |       **3** |        **49.373 ns** |      **0.3876 ns** |      **0.2564 ns** |  **1.00** |
| DefaultIfEmptyFaster |       3 |         5.787 ns |      0.0835 ns |      0.0552 ns |  0.12 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |       **5** |        **51.236 ns** |      **0.2453 ns** |      **0.1460 ns** |  **1.00** |
| DefaultIfEmptyFaster |       5 |         5.785 ns |      0.0743 ns |      0.0491 ns |  0.11 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |      **10** |        **51.865 ns** |      **0.6080 ns** |      **0.4022 ns** |  **1.00** |
| DefaultIfEmptyFaster |      10 |         5.752 ns |      0.0313 ns |      0.0186 ns |  0.11 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |      **50** |        **56.334 ns** |      **0.5145 ns** |      **0.3062 ns** |  **1.00** |
| DefaultIfEmptyFaster |      50 |         5.780 ns |      0.0883 ns |      0.0584 ns |  0.10 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |     **100** |        **64.614 ns** |      **0.6807 ns** |      **0.4502 ns** |  **1.00** |
| DefaultIfEmptyFaster |     100 |         5.748 ns |      0.0891 ns |      0.0589 ns |  0.09 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |     **250** |        **95.906 ns** |      **0.9217 ns** |      **0.6097 ns** |  **1.00** |
| DefaultIfEmptyFaster |     250 |         5.783 ns |      0.0814 ns |      0.0538 ns |  0.06 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |     **500** |       **155.107 ns** |      **3.0148 ns** |      **1.9941 ns** |  **1.00** |
| DefaultIfEmptyFaster |     500 |         5.743 ns |      0.0781 ns |      0.0517 ns |  0.04 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |    **1000** |       **253.413 ns** |      **2.2780 ns** |      **1.3556 ns** |  **1.00** |
| DefaultIfEmptyFaster |    1000 |         5.733 ns |      0.0433 ns |      0.0258 ns |  0.02 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |    **1500** |       **371.111 ns** |     **10.5037 ns** |      **6.9475 ns** |  **1.00** |
| DefaultIfEmptyFaster |    1500 |         5.758 ns |      0.0541 ns |      0.0358 ns |  0.02 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |    **2000** |       **480.844 ns** |      **5.0523 ns** |      **3.0066 ns** |  **1.00** |
| DefaultIfEmptyFaster |    2000 |         5.804 ns |      0.0767 ns |      0.0507 ns |  0.01 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |    **2500** |       **567.167 ns** |      **8.4466 ns** |      **5.0265 ns** |  **1.00** |
| DefaultIfEmptyFaster |    2500 |         5.790 ns |      0.0892 ns |      0.0531 ns |  0.01 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |    **3000** |       **657.783 ns** |      **6.0210 ns** |      **3.5830 ns** | **1.000** |
| DefaultIfEmptyFaster |    3000 |         5.743 ns |      0.0536 ns |      0.0355 ns | 0.009 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |    **5000** |     **1,068.876 ns** |     **61.3916 ns** |     **40.6067 ns** | **1.000** |
| DefaultIfEmptyFaster |    5000 |         5.749 ns |      0.0885 ns |      0.0463 ns | 0.005 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |   **10000** |     **2,113.165 ns** |     **24.0037 ns** |     **12.5544 ns** | **1.000** |
| DefaultIfEmptyFaster |   10000 |         5.800 ns |      0.0924 ns |      0.0611 ns | 0.003 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |   **50000** |    **11,877.917 ns** |    **226.4706 ns** |    **134.7690 ns** | **1.000** |
| DefaultIfEmptyFaster |   50000 |         5.540 ns |      0.0518 ns |      0.0343 ns | 0.000 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |  **100000** |    **42,103.383 ns** |    **610.9150 ns** |    **404.0825 ns** | **1.000** |
| DefaultIfEmptyFaster |  100000 |         5.567 ns |      0.0739 ns |      0.0489 ns | 0.000 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** |  **500000** |   **572,783.496 ns** | **95,136.9803 ns** | **62,927.2220 ns** | **1.000** |
| DefaultIfEmptyFaster |  500000 |         5.566 ns |      0.0208 ns |      0.0138 ns | 0.000 |
|                      |         |                  |                |                |       |
|   **DefaultIfEmptyLinq** | **1000000** | **1,498,497.090 ns** | **30,435.6313 ns** | **20,131.2857 ns** | **1.000** |
| DefaultIfEmptyFaster | 1000000 |         5.580 ns |      0.0865 ns |      0.0572 ns | 0.000 |
