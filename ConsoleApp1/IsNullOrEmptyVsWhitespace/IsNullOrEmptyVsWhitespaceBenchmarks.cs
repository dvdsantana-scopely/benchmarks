using BenchmarkDotNet.Attributes;

namespace ConsoleApp1.IsNullOrEmptyVsWhitespace
{
    [MarkdownExporter]
    [MemoryDiagnoser()]
    public class IsNullOrEmptyVsWhitespaceBenchmarks
    {
        private const string Sample = "sample";

        [Benchmark]
        public bool IsNullOrEmpty() => string.IsNullOrEmpty(Sample);
        
        [Benchmark]
        public bool IsNullOrWhiteSpace() => string.IsNullOrWhiteSpace(Sample);
    }
}