using BenchmarkDotNet.Attributes;

namespace ConsoleApp1
{
    [MemoryDiagnoser()]
    public class StringSplitVsSpanBenchmarks
    {
        private static readonly StringSplitVsSpanSamples Samples = new();
        private const string Data = "public-class-StringSplitVsSpanBenchmarks-private-static-readonly-string-Data";
        private const string Separator = "-";

        [Benchmark]
        public string LastStringWithSpan() => Samples.LastStringWithSpan(Data, Separator);
        
        [Benchmark]
        public string LastStringWithSplit() => Samples.LastStringWithSplit(Data, Separator);
    }
}