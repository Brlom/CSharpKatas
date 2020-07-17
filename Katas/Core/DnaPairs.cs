using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Core
{
    public class DnaPairs
    {
        public char[][] pairsArr;
        private readonly Dictionary<char, char> pairMapping = new Dictionary<char, char>()
        {
            { 'G', 'C' },
            { 'C', 'G' },
            { 'T', 'A' },
            { 'A', 'T' }
        };

        public DnaPairs(string dna)
        {
            var pairsList = new List<char[]>();
            if (dna != String.Empty)
            {
                char[] charArr = dna.ToCharArray();
                foreach (char ch in charArr)
                { 
                    switch(Char.ToUpper(ch))
                    { 
                        case 'G':
                            pairsList.Add(new char[] { 'G', pairMapping['G'] });
                            break;
                        case 'C':
                            pairsList.Add(new char[] { 'C', pairMapping['C'] });
                            break;
                        case 'T':
                            pairsList.Add(new char[] { 'T', pairMapping['T'] });
                            break;
                        case 'A':
                            pairsList.Add(new char[] { 'A', pairMapping['A'] });
                            break;
                        default:
                            break;
                    }
                }
            }
            pairsArr = pairsList.ToArray();
        }

    }
}
