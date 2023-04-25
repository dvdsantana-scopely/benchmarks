``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
11th Gen Intel Core i7-11850H 2.50GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.202
  [Host]     : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  DefaultJob : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT


```
|     Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
|----------- |---------:|---------:|---------:|-------:|----------:|
|     InLine | 45.56 ns | 0.535 ns | 0.447 ns | 0.0057 |      72 B |
| WithMethod | 58.96 ns | 1.161 ns | 2.976 ns | 0.0108 |     136 B |
|  Predicate | 50.26 ns | 1.020 ns | 1.327 ns | 0.0057 |      72 B |
