``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-VDQUHN : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|              Method |       N |     Mean |    Error |   StdDev | Ratio |
|-------------------- |-------- |---------:|---------:|---------:|------:|
|   **SequenceEqualLinq** |       **0** | **32.41 ns** | **0.365 ns** | **0.242 ns** |  **1.00** |
| SequenceEqualFaster |       0 | 11.61 ns | 0.077 ns | 0.046 ns |  0.36 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |       **1** | **39.02 ns** | **0.328 ns** | **0.217 ns** |  **1.00** |
| SequenceEqualFaster |       1 | 12.08 ns | 0.097 ns | 0.064 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |       **3** | **39.22 ns** | **0.705 ns** | **0.466 ns** |  **1.00** |
| SequenceEqualFaster |       3 | 12.09 ns | 0.124 ns | 0.082 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |       **5** | **38.58 ns** | **0.361 ns** | **0.239 ns** |  **1.00** |
| SequenceEqualFaster |       5 | 12.02 ns | 0.110 ns | 0.072 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |      **10** | **38.74 ns** | **0.397 ns** | **0.236 ns** |  **1.00** |
| SequenceEqualFaster |      10 | 12.09 ns | 0.088 ns | 0.053 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |      **50** | **38.83 ns** | **0.335 ns** | **0.221 ns** |  **1.00** |
| SequenceEqualFaster |      50 | 12.06 ns | 0.063 ns | 0.033 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |     **100** | **38.68 ns** | **0.230 ns** | **0.152 ns** |  **1.00** |
| SequenceEqualFaster |     100 | 12.10 ns | 0.055 ns | 0.036 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |     **250** | **38.77 ns** | **0.288 ns** | **0.191 ns** |  **1.00** |
| SequenceEqualFaster |     250 | 12.06 ns | 0.088 ns | 0.058 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |     **500** | **36.52 ns** | **0.211 ns** | **0.140 ns** |  **1.00** |
| SequenceEqualFaster |     500 | 12.02 ns | 0.114 ns | 0.075 ns |  0.33 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |    **1000** | **38.92 ns** | **0.305 ns** | **0.202 ns** |  **1.00** |
| SequenceEqualFaster |    1000 | 12.07 ns | 0.078 ns | 0.052 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |    **1500** | **36.45 ns** | **0.261 ns** | **0.173 ns** |  **1.00** |
| SequenceEqualFaster |    1500 | 12.05 ns | 0.093 ns | 0.061 ns |  0.33 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |    **2000** | **39.00 ns** | **0.356 ns** | **0.186 ns** |  **1.00** |
| SequenceEqualFaster |    2000 | 12.02 ns | 0.083 ns | 0.055 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |    **2500** | **38.79 ns** | **0.234 ns** | **0.155 ns** |  **1.00** |
| SequenceEqualFaster |    2500 | 12.06 ns | 0.088 ns | 0.058 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |    **3000** | **38.90 ns** | **0.358 ns** | **0.213 ns** |  **1.00** |
| SequenceEqualFaster |    3000 | 12.07 ns | 0.093 ns | 0.062 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |    **5000** | **36.17 ns** | **0.321 ns** | **0.212 ns** |  **1.00** |
| SequenceEqualFaster |    5000 | 12.06 ns | 0.068 ns | 0.045 ns |  0.33 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |   **10000** | **38.75 ns** | **0.328 ns** | **0.217 ns** |  **1.00** |
| SequenceEqualFaster |   10000 | 12.08 ns | 0.093 ns | 0.061 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |   **50000** | **38.77 ns** | **0.353 ns** | **0.210 ns** |  **1.00** |
| SequenceEqualFaster |   50000 | 12.07 ns | 0.057 ns | 0.038 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |  **100000** | **38.86 ns** | **0.368 ns** | **0.243 ns** |  **1.00** |
| SequenceEqualFaster |  100000 | 12.06 ns | 0.108 ns | 0.071 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** |  **500000** | **38.84 ns** | **0.342 ns** | **0.226 ns** |  **1.00** |
| SequenceEqualFaster |  500000 | 12.06 ns | 0.094 ns | 0.062 ns |  0.31 |
|                     |         |          |          |          |       |
|   **SequenceEqualLinq** | **1000000** | **38.88 ns** | **0.473 ns** | **0.313 ns** |  **1.00** |
| SequenceEqualFaster | 1000000 | 12.10 ns | 0.098 ns | 0.065 ns |  0.31 |
