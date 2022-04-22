using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class LinqLoopSamples
    {
        private const int Threshold = 5000;

        public List<int> ForLoop(List<LinqLoopBenchmarks.Seed.LinqData> data)
        {
            var values = new List<int>();
            for (int i = 0; i < data.Count; i++) {
                if(data[i].Value > Threshold)
                    values.Add(data[i].ValueTwo);
            }

            return values;
        }
        
        public List<int> Linq(List<LinqLoopBenchmarks.Seed.LinqData> data)
        {
            var values = data
                .Where(d => d.Value > Threshold)
                .Select(v => v.ValueTwo)
                .ToList();
            
            return values;
        }

        public List<int> Collection(List<LinqLoopBenchmarks.Seed.LinqData> data)
        {
            var values = data
                .FindAll(d => d.Value > Threshold)
                .Select(v => v.ValueTwo)
                .ToList();
            
            return values;
        }
    }
}