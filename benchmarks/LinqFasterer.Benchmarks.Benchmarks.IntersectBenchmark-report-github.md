``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|          Method |       N |             Mean |          Error |        StdDev | Ratio |
|---------------- |-------- |-----------------:|---------------:|--------------:|------:|
|   **IntersectLinq** |       **0** |         **92.49 ns** |       **0.936 ns** |      **0.557 ns** |  **1.00** |
| IntersectFaster |       0 |         50.58 ns |       0.550 ns |      0.364 ns |  0.55 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |       **1** |        **127.77 ns** |       **0.843 ns** |      **0.558 ns** |  **1.00** |
| IntersectFaster |       1 |         92.36 ns |       1.062 ns |      0.703 ns |  0.72 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |       **3** |        **188.54 ns** |       **3.151 ns** |      **2.084 ns** |  **1.00** |
| IntersectFaster |       3 |        125.97 ns |       1.176 ns |      0.700 ns |  0.67 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |       **5** |        **225.72 ns** |       **3.031 ns** |      **2.005 ns** |  **1.00** |
| IntersectFaster |       5 |        161.43 ns |       1.300 ns |      0.860 ns |  0.72 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |      **10** |        **449.43 ns** |       **4.046 ns** |      **2.676 ns** |  **1.00** |
| IntersectFaster |      10 |        280.66 ns |       2.853 ns |      1.698 ns |  0.62 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |      **50** |      **2,547.62 ns** |      **60.477 ns** |     **40.001 ns** |  **1.00** |
| IntersectFaster |      50 |      1,062.74 ns |      12.161 ns |      8.044 ns |  0.42 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |     **100** |      **4,745.60 ns** |      **39.471 ns** |     **26.108 ns** |  **1.00** |
| IntersectFaster |     100 |      2,307.66 ns |      32.376 ns |     21.415 ns |  0.49 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |     **250** |     **11,227.35 ns** |      **44.474 ns** |     **29.417 ns** |  **1.00** |
| IntersectFaster |     250 |      6,112.10 ns |      31.458 ns |     16.453 ns |  0.54 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |     **500** |     **22,128.66 ns** |     **339.532 ns** |    **224.579 ns** |  **1.00** |
| IntersectFaster |     500 |     13,574.00 ns |     108.054 ns |     71.471 ns |  0.61 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |    **1000** |     **43,476.92 ns** |     **333.959 ns** |    **220.893 ns** |  **1.00** |
| IntersectFaster |    1000 |     26,846.02 ns |     320.153 ns |    190.518 ns |  0.62 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |    **1500** |     **60,211.49 ns** |     **717.683 ns** |    **375.362 ns** |  **1.00** |
| IntersectFaster |    1500 |     37,781.13 ns |     488.762 ns |    290.855 ns |  0.63 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |    **2000** |     **74,736.37 ns** |     **928.645 ns** |    **614.241 ns** |  **1.00** |
| IntersectFaster |    2000 |     49,802.65 ns |     428.694 ns |    283.555 ns |  0.67 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |    **2500** |     **88,333.41 ns** |     **810.105 ns** |    **535.834 ns** |  **1.00** |
| IntersectFaster |    2500 |     61,036.62 ns |     655.155 ns |    433.345 ns |  0.69 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |    **3000** |    **101,313.87 ns** |     **710.790 ns** |    **470.144 ns** |  **1.00** |
| IntersectFaster |    3000 |     71,563.73 ns |     918.506 ns |    607.535 ns |  0.71 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |    **5000** |    **152,846.00 ns** |   **1,132.551 ns** |    **749.113 ns** |  **1.00** |
| IntersectFaster |    5000 |    122,651.04 ns |   1,682.443 ns |  1,112.832 ns |  0.80 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |   **10000** |    **275,235.37 ns** |   **4,630.560 ns** |  **3,062.829 ns** |  **1.00** |
| IntersectFaster |   10000 |    233,003.88 ns |   2,035.697 ns |  1,346.488 ns |  0.85 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |   **50000** |  **1,256,560.70 ns** |  **13,195.206 ns** |  **8,727.812 ns** |  **1.00** |
| IntersectFaster |   50000 |  1,062,202.95 ns |  10,909.760 ns |  7,216.131 ns |  0.85 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |  **100000** |  **2,477,694.96 ns** |  **24,065.335 ns** | **15,917.729 ns** |  **1.00** |
| IntersectFaster |  100000 |  2,151,216.21 ns |  12,616.244 ns |  8,344.864 ns |  0.87 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** |  **500000** | **12,344,958.44 ns** |  **90,984.953 ns** | **60,180.913 ns** |  **1.00** |
| IntersectFaster |  500000 | 10,732,697.19 ns |  81,064.819 ns | 53,619.359 ns |  0.87 |
|                 |         |                  |                |               |       |
|   **IntersectLinq** | **1000000** | **24,513,288.67 ns** | **105,001.376 ns** | **54,917.750 ns** |  **1.00** |
| IntersectFaster | 1000000 | 20,715,068.75 ns | 144,923.878 ns | 95,858.172 ns |  0.85 |
