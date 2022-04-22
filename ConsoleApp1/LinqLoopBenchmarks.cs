using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace ConsoleApp1
{
    [MemoryDiagnoser()]
    public class LinqLoopBenchmarks
    {
        private static readonly LinqLoopSamples Samples = new();
        private static readonly List<Seed.LinqData> Data = Seed.Generate();

        [Benchmark]
        public List<int> ForLoop() => Samples.ForLoop(Data);

        [Benchmark]
        public List<int> Linq() => Samples.Linq(Data);

        [Benchmark]
        public List<int> Collection() => Samples.Collection(Data);
        
        public static class Seed
        {
            private const int Count = 10000;
        
            public static List<LinqData> Generate()
            {
                var data = new List<LinqData>();
                for (int i = 0; i < Count; i++)
                {
                    var rand = new Random();
                    data.Add(new LinqData()
                    {
                        Value = rand.Next(0, 1000000),
                        ValueTwo = rand.Next(0, 1000000),
                    });
                }

                return data;
            }

            public struct LinqData {
                public int Value;
                public int ValueTwo;
            }
        }
    }
}