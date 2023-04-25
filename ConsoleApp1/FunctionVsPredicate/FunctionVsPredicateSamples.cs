using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.FunctionVsPredicate
{
    public class FunctionVsPredicateSamples
    {
        public int WithMethod(List<string> data)
        {
            var result = data
                .Where(myMethod);
            
            return result.Count();
        }

        private bool myMethod(string x)
        {
            return x.StartsWith('a');
        }

        public int Predicate(List<string> data)
        {
            Func<string,bool> predicate = x => x.StartsWith('a');
            
            var result = data
                .Where(predicate);
            
            return result.Count();
        }
        
        public int InLine(List<string> data)
        {
            var result = data
                .Where(x => x.StartsWith('a'));
            
            return result.Count();
        }
    }
}