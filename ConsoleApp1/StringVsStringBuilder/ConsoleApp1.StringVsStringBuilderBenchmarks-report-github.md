``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
11th Gen Intel Core i7-11850H 2.50GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.202
  [Host]     : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT
  DefaultJob : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT


```
|                            Method |        Mean |      Error |     StdDev |      Median |  Gen 0 |  Gen 1 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|------------:|-------:|-------:|----------:|
|        ConcatFewStringsWithString |    41.98 ns |   0.991 ns |   2.892 ns |    41.67 ns | 0.0050 |      - |      64 B |
| ConcatFewStringsWithStringBuilder |    44.44 ns |   0.954 ns |   2.212 ns |    44.37 ns | 0.0108 |      - |     136 B |
|       ConcatStringsWithStringJoin |    87.08 ns |   8.025 ns |  23.661 ns |    72.92 ns | 0.0057 |      - |      72 B |
|        ConcatBigStringsWithString | 3,867.16 ns | 159.847 ns | 442.935 ns | 3,747.03 ns | 1.6594 | 0.0038 |  20,856 B |
| ConcatBigStringsWithStringBuilder | 1,218.49 ns | 112.043 ns | 330.361 ns | 1,054.80 ns | 0.1011 |      - |   1,280 B |
|    ConcatBigStringsWithStringJoin | 1,912.02 ns | 102.613 ns | 279.166 ns | 1,838.97 ns | 0.0343 |      - |     448 B |
