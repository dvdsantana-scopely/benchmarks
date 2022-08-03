``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-11850H 2.50GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.202
  [Host]     : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT
  DefaultJob : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT


```
|              Method |      Mean |    Error |   StdDev |  Gen 0 | Allocated |
|-------------------- |----------:|---------:|---------:|-------:|----------:|
|  LastStringWithSpan |  14.59 ns | 0.169 ns | 0.159 ns | 0.0025 |      32 B |
| LastStringWithSplit | 191.24 ns | 3.770 ns | 4.629 ns | 0.0343 |     432 B |
