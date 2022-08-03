``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-11850H 2.50GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.202
  [Host]     : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT
  DefaultJob : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT


```
|                            Method |        Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
|---------------------------------- |------------:|----------:|----------:|-------:|-------:|----------:|
|        ConcatFewStringsWithString |    35.71 ns |  0.697 ns |  0.652 ns | 0.0051 |      - |      64 B |
| ConcatFewStringsWithStringBuilder |    36.33 ns |  0.566 ns |  0.529 ns | 0.0108 |      - |     136 B |
|        ConcatBigStringsWithString | 2,886.89 ns | 41.622 ns | 38.933 ns | 1.6594 | 0.0038 |  20,856 B |
| ConcatBigStringsWithStringBuilder |   719.64 ns | 10.654 ns |  9.966 ns | 0.1011 |      - |   1,280 B |
