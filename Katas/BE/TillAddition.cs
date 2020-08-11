using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.BE
{
    public class TillAddition
    {
        public string GetSumOfCashInTill(Dictionary<string, int> tillContents)
        {
            if (tillContents.Count == 0)
            { 
                return "£0.00";
            }

            double totalSum = 0;

            foreach(KeyValuePair<string, int> entry in tillContents)
            {
                // entry.Value && entry.Key
                if (entry.Value != 0)
                {
                    char[] charArr = entry.Key.ToCharArray();
                    foreach (char c in charArr)
                    {
                        double numericCharValue = Char.GetNumericValue(c);

                        if (numericCharValue.GetType() == typeof(int))
                        {
                            totalSum += numericCharValue * entry.Value;
                        }
                    }
                    // convert entry.key to int
                }
            }
            return "£0.00";
        }
    }
}
