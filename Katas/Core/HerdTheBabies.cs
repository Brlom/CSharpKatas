using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas.Core
{
    public class HerdTheBabies
    {

        public string SortTheBabies(string original)
        {
            if (original == string.Empty)
            {
                return string.Empty;
            }

            Regex upperCaseMatch = new Regex(@"[A-Z]");
            string finalStr = string.Empty;

            if (upperCaseMatch.IsMatch(original))
            {
                var upperMatch = Regex.Matches(original, @"[A-Z]+").OfType<Match>().Select(m => m.Value).ToList<string>();
                var lowerMatch = Regex.Matches(original, @"[a-z]+").OfType<Match>().Select(m => m.Value).ToList<string>();
             
                finalStr = upperMatch.Aggregate("", (total, next) => total += next);
                finalStr = lowerMatch.Aggregate(finalStr, (total, next) => total += next);
                
            }
            else
            {
                finalStr += original;
            }
           
            return finalStr;
        }

    }
}
