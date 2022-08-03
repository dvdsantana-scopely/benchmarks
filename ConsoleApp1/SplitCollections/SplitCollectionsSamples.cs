using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class SplitCollectionsSamples
    {
        public (List<int> odds, List<int> evens) SplitWithForeach(List<int> data)
        {
            var odds = new List<int>();
            var evens = new List<int>();
            
            foreach (var number in data)
            {
                if (number%2 == 0)
                {
                    odds.Add(number);
                }
                else
                {
                    evens.Add(number);
                }
            }

            return (odds, evens);
        }

        public (List<int> odds, List<int> evens) SplitWithForCached(List<int> data)
        {
            var odds = new List<int>();
            var evens = new List<int>();

            var count = data.Count;
            for (int i = 0; i < count; i++)
            {
                var number = data[i];
                if (number % 2 == 0)
                {
                    odds.Add(number);
                }
                else
                {
                    evens.Add(number);
                }
            }

            return (odds, evens);
        }

        public (List<int> odds, List<int> evens) SplitWithWhere(List<int> data)
        {
            var odds = data.Where(x => x % 2 == 0).ToList();
            var evens = data.Where(x => x % 2 != 0).ToList();

            return (odds, evens);
        }
    }
}