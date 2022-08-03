using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ConsoleApp1
{
    [MarkdownExporter]
    [MemoryDiagnoser()]
    public class SplitCollectionsBenchmarks
    {
        private static readonly SplitCollectionsSamples Samples = new();
        private static readonly List<int> Data = Seed.Generate();

        [Benchmark]
        public (List<int> odds, List<int> evens) SplitWithForeach() => Samples.SplitWithForeach(Data);

        [Benchmark]
        public (List<int> odds, List<int> evens) SplitWithForCached() => Samples.SplitWithForCached(Data);

        [Benchmark]
        public (List<int> odds, List<int> evens) SplitWithWhere() => Samples.SplitWithWhere(Data);
        
        public static class Seed
        {
            public static List<int> Generate() => Enumerable.Range(1, 1000).ToList();
        }
    }
}