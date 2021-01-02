``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  Job-CWYCNQ : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|               Method |       N |           Mean |         Error |        StdDev | Ratio |
|--------------------- |-------- |---------------:|--------------:|--------------:|------:|
| **ConcatMultipleFaster** |       **0** |       **102.1 ns** |       **0.97 ns** |       **0.64 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |       **1** |       **103.3 ns** |       **1.00 ns** |       **0.66 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |       **3** |       **104.5 ns** |       **1.10 ns** |       **0.73 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |       **5** |       **108.0 ns** |       **0.77 ns** |       **0.51 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |      **10** |       **119.6 ns** |       **2.31 ns** |       **1.53 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |      **50** |       **183.5 ns** |      **43.42 ns** |      **28.72 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |     **100** |       **292.8 ns** |      **48.59 ns** |      **28.91 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |     **250** |       **593.7 ns** |     **228.65 ns** |     **136.07 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |     **500** |     **1,143.6 ns** |     **513.59 ns** |     **339.71 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |    **1000** |     **2,255.4 ns** |      **27.89 ns** |      **18.45 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |    **1500** |     **2,918.8 ns** |     **871.60 ns** |     **576.51 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |    **2000** |     **4,165.6 ns** |      **83.66 ns** |      **49.79 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |    **2500** |     **3,944.1 ns** |   **1,742.57 ns** |   **1,152.60 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |    **3000** |     **5,677.4 ns** |   **2,165.49 ns** |   **1,432.34 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |    **5000** |     **7,086.4 ns** |   **2,993.59 ns** |   **1,980.08 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |   **10000** |    **17,123.7 ns** |   **5,962.78 ns** |   **3,944.01 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |   **50000** |   **114,862.7 ns** |   **2,563.12 ns** |   **1,525.27 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |  **100000** |   **304,088.6 ns** |  **15,492.36 ns** |  **10,247.24 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** |  **500000** | **3,778,040.5 ns** |  **69,504.16 ns** |  **45,972.70 ns** |  **1.00** |
|                      |         |                |               |               |       |
| **ConcatMultipleFaster** | **1000000** | **5,232,257.9 ns** | **300,309.27 ns** | **198,635.99 ns** |  **1.00** |
