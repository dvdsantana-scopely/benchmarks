``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-11850H 2.50GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.202
  [Host]     : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT
  DefaultJob : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT


```
|     Method |      Mean |    Error |   StdDev |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|----------- |----------:|---------:|---------:|--------:|--------:|--------:|----------:|
|    ForLoop |  26.62 μs | 0.515 μs | 1.495 μs | 10.4065 |  3.4485 |       - |    128 KB |
|       Linq | 121.23 μs | 2.278 μs | 2.131 μs | 10.3760 |  3.4180 |       - |    128 KB |
| Collection | 134.55 μs | 1.743 μs | 1.630 μs | 41.5039 | 41.5039 | 41.5039 |    295 KB |
