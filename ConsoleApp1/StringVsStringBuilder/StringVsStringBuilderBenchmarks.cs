using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ConsoleApp1
{
    [MarkdownExporter]
    [MemoryDiagnoser()]
    public class StringVsStringBuilderBenchmarks
    {
        private static readonly StringVsStringBuilderSamples Samples = new();
        private static readonly List<string> Data = Seed.Generate(3);
        private static readonly List<string> Data100 = Seed.Generate(100);

        [Benchmark]
        public string ConcatFewStringsWithString() => Samples.ConcatStringsWithString(Data);

        [Benchmark]
        public string ConcatFewStringsWithStringBuilder() => Samples.ConcatStringsWithStringBuilder(Data);

        [Benchmark]
        public string ConcatBigStringsWithString() => Samples.ConcatStringsWithString(Data100);

        [Benchmark]
        public string ConcatBigStringsWithStringBuilder() => Samples.ConcatStringsWithStringBuilder(Data100);
        
        public static class Seed
        {
            public static List<string> Generate(int count) =>
                Enumerable.Range(1, count)
                    .Select(x => x.ToString())
                    .ToList();
        }
    }
}