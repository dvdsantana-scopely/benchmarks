using System;
using System.Linq;

namespace ConsoleApp1
{
    public class StringSplitVsSpanSamples
    {
        public string LastStringWithSplit(string str, string separator)
        {
            var lastValue = str.Split(separator).Last();
            return lastValue;
        }

        public string LastStringWithSpan(string str, string separator)
        {
            ReadOnlySpan<char> span = str;
            var lastIndex = span.LastIndexOf(separator);
            var lastValue = span.Slice(lastIndex+1, span.Length-lastIndex-1);
            return lastValue.ToString();
        }
    }
}