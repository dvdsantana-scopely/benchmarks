using BenchmarkDotNet.Running;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<LinqLoopBenchmarks>();
            //BenchmarkRunner.Run<NullEmptyValuesBenchmarks>();
            //BenchmarkRunner.Run<SplitCollectionsBenchmarks>();
            //BenchmarkRunner.Run<StringVsStringBuilderBenchmarks>();
            BenchmarkRunner.Run<StringSplitVsSpanBenchmarks>();
            
        }
    }
}