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

            string sortedStr = String.Concat(original.OrderBy(c => c));

            var dictionary = new Dictionary<char, string>();
            string finalStr = String.Empty;

            foreach (char c in sortedStr)
            {
                char curr = Char.ToLower(c);
                if (dictionary.ContainsKey(curr))
                {
                    dictionary[curr] += c;
                }
                else
                {
                    dictionary.Add(curr, c.ToString());
                }
            }

            foreach (var pair in dictionary.OrderBy(p => p.Key))
            {
                finalStr += pair.Value;
            }

            return finalStr;
        }

    }
}
