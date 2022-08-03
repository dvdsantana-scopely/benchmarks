``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-11850H 2.50GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.202
  [Host]     : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT
  DefaultJob : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT


```
|             Method |     Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
|------------------- |---------:|----------:|----------:|-------:|-------:|----------:|
|   SplitWithForeach | 3.441 μs | 0.0641 μs | 0.0738 μs | 0.6828 | 0.1335 |      8 KB |
| SplitWithForCached | 2.279 μs | 0.0301 μs | 0.0282 μs | 0.6828 | 0.1335 |      8 KB |
|     SplitWithWhere | 4.901 μs | 0.0913 μs | 0.0976 μs | 0.6943 | 0.1373 |      9 KB |
