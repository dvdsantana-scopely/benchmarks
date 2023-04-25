using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace ConsoleApp1.FunctionVsPredicate
{
    [MarkdownExporter]
    [MemoryDiagnoser()]
    [MarkdownExporterAttribute.GitHub]
    public class FunctionVsPredicateBenchmark
    {
        private List<string> data = new List<string>() { "asdsdsd", "sdasd", "aqweqwe", "werwer", "asdfsdf", "ertert", "aqweqweq"};
        private static readonly FunctionVsPredicateSamples Samples = new FunctionVsPredicateSamples();

        [Benchmark]
        public int InLine() => Samples.InLine(data);

        [Benchmark]
        public int WithMethod() => Samples.WithMethod(data);

        [Benchmark]
        public int Predicate() => Samples.Predicate(data);
    }
}