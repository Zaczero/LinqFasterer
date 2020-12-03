``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|          Method |       N |      Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------- |-------- |----------:|----------:|----------:|------:|--------:|
|   **ElementAtLinq** |       **0** |        **NA** |        **NA** |        **NA** |     **?** |       **?** |
| ElementAtFaster |       0 |        NA |        NA |        NA |     ? |       ? |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |       **1** |        **NA** |        **NA** |        **NA** |     **?** |       **?** |
| ElementAtFaster |       1 |        NA |        NA |        NA |     ? |       ? |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |       **3** |        **NA** |        **NA** |        **NA** |     **?** |       **?** |
| ElementAtFaster |       3 |        NA |        NA |        NA |     ? |       ? |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |       **5** |        **NA** |        **NA** |        **NA** |     **?** |       **?** |
| ElementAtFaster |       5 |        NA |        NA |        NA |     ? |       ? |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |      **10** | **18.092 ns** | **0.0783 ns** | **0.0518 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |      10 |  1.220 ns | 0.0196 ns | 0.0130 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |      **50** | **16.600 ns** | **0.1209 ns** | **0.0800 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |      50 |  1.232 ns | 0.0129 ns | 0.0085 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |     **100** | **16.529 ns** | **0.1788 ns** | **0.1183 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |     100 |  1.230 ns | 0.0184 ns | 0.0122 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |     **250** | **16.562 ns** | **0.1898 ns** | **0.1255 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |     250 |  1.232 ns | 0.0172 ns | 0.0114 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |     **500** | **16.639 ns** | **0.1485 ns** | **0.0982 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |     500 |  1.237 ns | 0.0180 ns | 0.0119 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |    **1000** | **17.990 ns** | **0.1582 ns** | **0.1046 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |    1000 |  1.232 ns | 0.0180 ns | 0.0107 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |    **1500** | **16.666 ns** | **0.1437 ns** | **0.0950 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |    1500 |  1.240 ns | 0.0183 ns | 0.0121 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |    **2000** | **16.525 ns** | **0.1710 ns** | **0.1131 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |    2000 |  1.247 ns | 0.0248 ns | 0.0164 ns |  0.08 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |    **2500** | **18.051 ns** | **0.2330 ns** | **0.1541 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |    2500 |  1.231 ns | 0.0236 ns | 0.0156 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |    **3000** | **18.061 ns** | **0.1076 ns** | **0.0640 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |    3000 |  1.232 ns | 0.0126 ns | 0.0084 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |    **5000** | **16.720 ns** | **0.1178 ns** | **0.0779 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |    5000 |  1.233 ns | 0.0097 ns | 0.0064 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |   **10000** | **18.043 ns** | **0.0992 ns** | **0.0590 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |   10000 |  1.237 ns | 0.0124 ns | 0.0074 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |   **50000** | **18.007 ns** | **0.1136 ns** | **0.0676 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |   50000 |  1.249 ns | 0.0245 ns | 0.0162 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |  **100000** | **16.607 ns** | **0.2071 ns** | **0.1370 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |  100000 |  1.230 ns | 0.0252 ns | 0.0167 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** |  **500000** | **16.642 ns** | **0.1412 ns** | **0.0934 ns** |  **1.00** |    **0.00** |
| ElementAtFaster |  500000 |  1.226 ns | 0.0165 ns | 0.0109 ns |  0.07 |    0.00 |
|                 |         |           |           |           |       |         |
|   **ElementAtLinq** | **1000000** | **16.615 ns** | **0.1093 ns** | **0.0723 ns** |  **1.00** |    **0.00** |
| ElementAtFaster | 1000000 |  1.223 ns | 0.0230 ns | 0.0152 ns |  0.07 |    0.00 |

Benchmarks with issues:
  ElementAtBenchmark.ElementAtLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
  ElementAtBenchmark.ElementAtFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=0]
  ElementAtBenchmark.ElementAtLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1]
  ElementAtBenchmark.ElementAtFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=1]
  ElementAtBenchmark.ElementAtLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=3]
  ElementAtBenchmark.ElementAtFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=3]
  ElementAtBenchmark.ElementAtLinq: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=5]
  ElementAtBenchmark.ElementAtFaster: Job-VDQUHN(IterationCount=10, LaunchCount=1, WarmupCount=2) [N=5]
