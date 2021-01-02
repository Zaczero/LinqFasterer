``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  Job-GNPIJF : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT

IterationCount=10  LaunchCount=1  WarmupCount=2  

```
|                  Method |       N |              Mean |            Error |         StdDev | Ratio | RatioSD |
|------------------------ |-------- |------------------:|-----------------:|---------------:|------:|--------:|
|   **OrderByDescendingLinq** |       **0** |          **44.64 ns** |         **0.768 ns** |       **0.508 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |       0 |          22.56 ns |         0.349 ns |       0.231 ns |  0.51 |    0.01 |
|   OrderDescendingFaster |       0 |          13.86 ns |         0.075 ns |       0.050 ns |  0.31 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |       **1** |         **126.19 ns** |         **2.039 ns** |       **1.213 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |       1 |          30.43 ns |         1.370 ns |       0.906 ns |  0.24 |    0.01 |
|   OrderDescendingFaster |       1 |          13.68 ns |         0.082 ns |       0.043 ns |  0.11 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |       **3** |         **165.33 ns** |        **14.867 ns** |       **9.833 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |       3 |          49.64 ns |         0.445 ns |       0.265 ns |  0.30 |    0.02 |
|   OrderDescendingFaster |       3 |          25.52 ns |         0.177 ns |       0.117 ns |  0.15 |    0.01 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |       **5** |         **188.44 ns** |        **12.901 ns** |       **8.533 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |       5 |          73.50 ns |         7.397 ns |       4.402 ns |  0.39 |    0.02 |
|   OrderDescendingFaster |       5 |          38.93 ns |         0.357 ns |       0.236 ns |  0.21 |    0.01 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |      **10** |         **379.32 ns** |        **16.005 ns** |      **10.586 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |      10 |         123.08 ns |         2.574 ns |       1.702 ns |  0.32 |    0.01 |
|   OrderDescendingFaster |      10 |          84.26 ns |         0.703 ns |       0.465 ns |  0.22 |    0.01 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |      **50** |       **2,426.23 ns** |        **54.572 ns** |      **36.096 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |      50 |         466.72 ns |        17.939 ns |      11.865 ns |  0.19 |    0.00 |
|   OrderDescendingFaster |      50 |         200.00 ns |         1.280 ns |       0.847 ns |  0.08 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |     **100** |       **6,155.26 ns** |        **69.160 ns** |      **45.745 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |     100 |       1,106.93 ns |        41.398 ns |      27.382 ns |  0.18 |    0.00 |
|   OrderDescendingFaster |     100 |         555.59 ns |         3.163 ns |       2.092 ns |  0.09 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |     **250** |      **18,443.89 ns** |       **278.015 ns** |     **183.889 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |     250 |       2,991.45 ns |        43.625 ns |      28.855 ns |  0.16 |    0.00 |
|   OrderDescendingFaster |     250 |       1,614.85 ns |        26.902 ns |      16.009 ns |  0.09 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |     **500** |      **41,305.59 ns** |       **730.077 ns** |     **434.457 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |     500 |       6,717.52 ns |        61.266 ns |      40.524 ns |  0.16 |    0.00 |
|   OrderDescendingFaster |     500 |       3,767.03 ns |        32.307 ns |      21.369 ns |  0.09 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |    **1000** |      **93,787.88 ns** |     **1,109.114 ns** |     **660.016 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |    1000 |      14,197.17 ns |        55.743 ns |      33.172 ns |  0.15 |    0.00 |
|   OrderDescendingFaster |    1000 |       8,334.27 ns |        71.056 ns |      42.284 ns |  0.09 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |    **1500** |     **148,730.51 ns** |     **2,568.922 ns** |   **1,699.183 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |    1500 |      24,915.84 ns |       243.253 ns |     144.756 ns |  0.17 |    0.00 |
|   OrderDescendingFaster |    1500 |      15,653.60 ns |       189.469 ns |     125.322 ns |  0.11 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |    **2000** |     **207,775.25 ns** |     **2,724.912 ns** |   **1,621.551 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |    2000 |      30,939.51 ns |       636.074 ns |     420.723 ns |  0.15 |    0.00 |
|   OrderDescendingFaster |    2000 |      18,747.16 ns |       132.409 ns |      87.580 ns |  0.09 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |    **2500** |     **269,676.01 ns** |     **5,098.731 ns** |   **3,034.173 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |    2500 |      40,846.86 ns |     1,106.925 ns |     732.163 ns |  0.15 |    0.00 |
|   OrderDescendingFaster |    2500 |      25,382.39 ns |       107.356 ns |      63.886 ns |  0.09 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |    **3000** |     **333,933.88 ns** |     **2,897.117 ns** |   **1,916.263 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |    3000 |      48,445.29 ns |       594.453 ns |     393.194 ns |  0.15 |    0.00 |
|   OrderDescendingFaster |    3000 |      31,102.34 ns |       280.664 ns |     167.019 ns |  0.09 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |    **5000** |     **592,741.43 ns** |     **7,769.788 ns** |   **5,139.233 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |    5000 |      78,047.13 ns |     1,112.303 ns |     735.720 ns |  0.13 |    0.00 |
|   OrderDescendingFaster |    5000 |      55,269.96 ns |       199.899 ns |     104.551 ns |  0.09 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |   **10000** |   **1,322,311.78 ns** |    **13,429.549 ns** |   **8,882.815 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |   10000 |     162,554.03 ns |     3,217.112 ns |   1,914.452 ns |  0.12 |    0.00 |
|   OrderDescendingFaster |   10000 |     114,551.97 ns |     1,238.760 ns |     819.363 ns |  0.09 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |   **50000** |   **7,909,245.47 ns** |    **57,459.214 ns** |  **38,005.713 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |   50000 |     861,044.89 ns |     9,858.199 ns |   6,520.588 ns |  0.11 |    0.00 |
|   OrderDescendingFaster |   50000 |     560,589.69 ns |     2,965.898 ns |   1,764.958 ns |  0.07 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |  **100000** |  **17,334,900.31 ns** |   **424,661.675 ns** | **280,887.405 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |  100000 |   1,688,418.71 ns |    16,780.963 ns |   9,986.082 ns |  0.10 |    0.00 |
|   OrderDescendingFaster |  100000 |     963,124.74 ns |     3,862.734 ns |   2,554.959 ns |  0.06 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** |  **500000** |  **99,570,206.67 ns** |   **886,510.025 ns** | **586,371.492 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster |  500000 |   8,273,207.66 ns |    56,665.435 ns |  37,480.676 ns |  0.08 |    0.00 |
|   OrderDescendingFaster |  500000 |   5,109,529.77 ns |    31,153.792 ns |  20,606.304 ns |  0.05 |    0.00 |
|                         |         |                   |                  |                |       |         |
|   **OrderByDescendingLinq** | **1000000** | **193,261,214.81 ns** | **1,515,671.923 ns** | **901,952.050 ns** |  **1.00** |    **0.00** |
| OrderByDescendingFaster | 1000000 |  18,095,748.96 ns |   124,495.275 ns |  74,085.141 ns |  0.09 |    0.00 |
|   OrderDescendingFaster | 1000000 |   8,891,799.84 ns |    91,695.504 ns |  60,650.899 ns |  0.05 |    0.00 |
