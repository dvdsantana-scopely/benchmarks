using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class StringVsStringBuilderSamples
    {
        public string ConcatStringsWithString(List<string> data)
        {
            var result = "";
            foreach (var s in data)
            {
                result += s;
            }

            return result;
        }
        
        public string ConcatStringsWithStringBuilder(List<string> data)
        {
            var result = new StringBuilder();
            
            foreach (var s in data)
            {
                result.Append(s);
            }

            return result.ToString();
        }
    }
}