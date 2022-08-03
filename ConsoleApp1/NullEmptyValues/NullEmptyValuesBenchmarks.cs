using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace ConsoleApp1
{
    [MarkdownExporter]
    [MemoryDiagnoser()]
    public class NullEmptyValuesBenchmarks
    {
        private static readonly NullEmptyValuesSamples Samples = new();
        private static readonly List<Seed.MyObject> Data = Seed.Generate(); 

        [Benchmark]
        public void CleanListPreviously() => Samples.CleanListPreviously(Data);

        [Benchmark]
        public void FullList() => Samples.FullList(Data);
        
        public static class Seed
        {
            public static List<MyObject> Generate()
            {
                var sampleData = new List<MyObject>();
                for (var i = 0; i < 1000; i++)
                {
                    var id = Guid.NewGuid();
                    var value = id.ToString();
                    sampleData.Add(new MyObject(id, value));
                }

                var emptyObject = new MyObject(Guid.NewGuid(), string.Empty);
            
                sampleData.Insert(0, emptyObject);
                sampleData.Insert(10, emptyObject);
                sampleData.Insert(sampleData.Count, emptyObject);

                return sampleData;
            }
        
            public class MyObject
            {
                public Guid Id { get; set; }
                public string Value { get; set; }

                public MyObject(Guid id, string value)
                {
                    Id = id;
                    Value = value;
                }
            }
        }
    }
}