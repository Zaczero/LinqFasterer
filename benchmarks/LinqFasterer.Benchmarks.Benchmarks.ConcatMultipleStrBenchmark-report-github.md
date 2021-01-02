``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  Job-YRWAPE : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|                  Method |       N |             Mean |            Error |           StdDev | Ratio |
|------------------------ |-------- |-----------------:|-----------------:|-----------------:|------:|
| **ConcatMultipleStrFaster** |       **0** |         **18.16 ns** |         **0.085 ns** |         **0.044 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |       **1** |         **42.19 ns** |         **0.547 ns** |         **0.286 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |       **3** |        **118.78 ns** |         **0.632 ns** |         **0.376 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |       **5** |        **161.87 ns** |        **15.513 ns** |         **8.114 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |      **10** |        **340.52 ns** |        **35.915 ns** |        **23.755 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |      **50** |      **1,419.83 ns** |       **126.590 ns** |        **83.731 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |     **100** |      **2,772.84 ns** |       **267.772 ns** |       **177.114 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |     **250** |      **6,897.73 ns** |       **470.572 ns** |       **311.254 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |     **500** |     **13,378.00 ns** |     **1,296.667 ns** |       **678.182 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |    **1000** |     **27,910.04 ns** |     **1,952.925 ns** |     **1,291.739 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |    **1500** |     **41,015.13 ns** |     **4,050.671 ns** |     **2,679.268 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |    **2000** |     **55,135.62 ns** |     **3,320.782 ns** |     **2,196.492 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |    **2500** |     **66,174.39 ns** |     **7,336.160 ns** |     **4,852.416 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |    **3000** |     **83,154.15 ns** |     **6,992.411 ns** |     **4,625.047 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |    **5000** |    **146,546.62 ns** |    **14,788.408 ns** |     **9,781.617 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |   **10000** |    **296,345.19 ns** |    **26,288.396 ns** |    **17,388.147 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |   **50000** |  **3,565,489.61 ns** |    **62,385.025 ns** |    **41,263.831 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |  **100000** |  **7,698,162.73 ns** |   **210,898.773 ns** |   **139,496.480 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** |  **500000** | **36,133,279.17 ns** |   **532,531.859 ns** |   **316,901.167 ns** |  **1.00** |
|                         |         |                  |                  |                  |       |
| **ConcatMultipleStrFaster** | **1000000** | **76,287,620.00 ns** | **2,058,625.313 ns** | **1,361,653.182 ns** |  **1.00** |
