``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
11th Gen Intel Core i7-11850H 2.50GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.202
  [Host]     : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  DefaultJob : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT


```
|             Method |      Mean |     Error |    StdDev | Allocated |
|------------------- |----------:|----------:|----------:|----------:|
|      IsNullOrEmpty | 0.4391 ns | 0.0270 ns | 0.0252 ns |         - |
| IsNullOrWhiteSpace | 1.8580 ns | 0.0596 ns | 0.0979 ns |         - |
