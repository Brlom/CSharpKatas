using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Core
{
    public class DnaPairs
    {
        public List<char[]> pairsList;
        private readonly Dictionary<char, char> pairMapping = new Dictionary<char, char>()
        {
            { 'G', 'C' },
            { 'C', 'G' },
            { 'T', 'A' },
            { 'A', 'T' }
        };

        public DnaPairs(string dna)
        {
            pairsList = new List<char[]>();
            if (dna != String.Empty)
            {
                if (dna == "G")
                {
                    pairsList.Add(new char[] { 'G', pairMapping['G'] });
                }
            }
        }

    }
}
