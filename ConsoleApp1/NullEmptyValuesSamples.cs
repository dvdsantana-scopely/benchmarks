using System.Collections.Generic;

namespace ConsoleApp1
{
    public class NullEmptyValuesSamples
    {
        public void CleanListPreviously(List<NullEmptyValuesBenchmarks.Seed.MyObject> data)
        {
            data.RemoveAll(x => string.IsNullOrEmpty(x.Value));
            foreach (var s in data)
            {
                s.Id.ToString();
            }
        }

        public void FullList(List<NullEmptyValuesBenchmarks.Seed.MyObject> data)
        {
            foreach (var s in data)
            {
                if (string.IsNullOrEmpty(s.Value))
                {
                    continue;
                }

                s.Id.ToString();
            }
        }
    }
}