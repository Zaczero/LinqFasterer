``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|         Method |       N |      Mean |     Error |    StdDev | Ratio |
|--------------- |-------- |----------:|----------:|----------:|------:|
|   **TakeLastLinq** |       **0** | **46.586 ns** | **0.2839 ns** | **0.1878 ns** |  **1.00** |
| TakeLastFaster |       0 |  9.420 ns | 0.0730 ns | 0.0483 ns |  0.20 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |       **1** | **47.805 ns** | **0.3546 ns** | **0.2346 ns** |  **1.00** |
| TakeLastFaster |       1 |  9.425 ns | 0.0938 ns | 0.0620 ns |  0.20 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |       **3** | **55.959 ns** | **0.3602 ns** | **0.2144 ns** |  **1.00** |
| TakeLastFaster |       3 |  9.402 ns | 0.1336 ns | 0.0884 ns |  0.17 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |       **5** | **63.469 ns** | **0.4639 ns** | **0.3069 ns** |  **1.00** |
| TakeLastFaster |       5 |  9.425 ns | 0.0443 ns | 0.0293 ns |  0.15 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |      **10** | **61.206 ns** | **0.4165 ns** | **0.2755 ns** |  **1.00** |
| TakeLastFaster |      10 | 29.316 ns | 0.3762 ns | 0.2488 ns |  0.48 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |      **50** | **63.741 ns** | **0.4555 ns** | **0.2711 ns** |  **1.00** |
| TakeLastFaster |      50 | 29.195 ns | 0.2697 ns | 0.1784 ns |  0.46 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |     **100** | **61.069 ns** | **0.8140 ns** | **0.5384 ns** |  **1.00** |
| TakeLastFaster |     100 | 29.095 ns | 0.1337 ns | 0.0795 ns |  0.48 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |     **250** | **59.332 ns** | **0.3316 ns** | **0.1973 ns** |  **1.00** |
| TakeLastFaster |     250 | 28.917 ns | 0.2995 ns | 0.1782 ns |  0.49 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |     **500** | **61.767 ns** | **0.5930 ns** | **0.3923 ns** |  **1.00** |
| TakeLastFaster |     500 | 29.044 ns | 0.1804 ns | 0.0943 ns |  0.47 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |    **1000** | **63.923 ns** | **0.6480 ns** | **0.3856 ns** |  **1.00** |
| TakeLastFaster |    1000 | 29.031 ns | 0.3272 ns | 0.2164 ns |  0.45 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |    **1500** | **61.933 ns** | **0.7004 ns** | **0.4633 ns** |  **1.00** |
| TakeLastFaster |    1500 | 29.037 ns | 0.2822 ns | 0.1866 ns |  0.47 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |    **2000** | **63.963 ns** | **0.7149 ns** | **0.4728 ns** |  **1.00** |
| TakeLastFaster |    2000 | 28.953 ns | 0.3529 ns | 0.2100 ns |  0.45 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |    **2500** | **61.422 ns** | **0.4447 ns** | **0.2942 ns** |  **1.00** |
| TakeLastFaster |    2500 | 29.178 ns | 0.1371 ns | 0.0907 ns |  0.48 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |    **3000** | **61.604 ns** | **0.2902 ns** | **0.1727 ns** |  **1.00** |
| TakeLastFaster |    3000 | 29.130 ns | 0.0968 ns | 0.0576 ns |  0.47 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |    **5000** | **61.361 ns** | **0.4901 ns** | **0.3241 ns** |  **1.00** |
| TakeLastFaster |    5000 | 29.037 ns | 0.1566 ns | 0.1036 ns |  0.47 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |   **10000** | **61.759 ns** | **0.8469 ns** | **0.5040 ns** |  **1.00** |
| TakeLastFaster |   10000 | 29.214 ns | 0.2370 ns | 0.1410 ns |  0.47 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |   **50000** | **61.513 ns** | **0.5776 ns** | **0.3437 ns** |  **1.00** |
| TakeLastFaster |   50000 | 29.003 ns | 0.2827 ns | 0.1682 ns |  0.47 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |  **100000** | **61.257 ns** | **1.1843 ns** | **0.7833 ns** |  **1.00** |
| TakeLastFaster |  100000 | 28.880 ns | 0.1236 ns | 0.0647 ns |  0.47 |
|                |         |           |           |           |       |
|   **TakeLastLinq** |  **500000** | **63.255 ns** | **0.4006 ns** | **0.2384 ns** |  **1.00** |
| TakeLastFaster |  500000 | 28.777 ns | 0.3883 ns | 0.2031 ns |  0.46 |
|                |         |           |           |           |       |
|   **TakeLastLinq** | **1000000** | **60.739 ns** | **0.7923 ns** | **0.4715 ns** |  **1.00** |
| TakeLastFaster | 1000000 | 29.141 ns | 0.1643 ns | 0.1087 ns |  0.48 |
