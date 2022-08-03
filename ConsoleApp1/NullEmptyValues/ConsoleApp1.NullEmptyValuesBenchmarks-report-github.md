``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-11850H 2.50GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.202
  [Host]     : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT
  DefaultJob : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
|-------------------- |---------:|---------:|---------:|-------:|----------:|
| CleanListPreviously | 78.98 μs | 0.879 μs | 0.822 μs | 7.5684 |     94 KB |
|            FullList | 77.51 μs | 1.529 μs | 1.820 μs | 7.5684 |     94 KB |
