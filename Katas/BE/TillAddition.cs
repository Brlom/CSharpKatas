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

            double totalSum = 0.00;

            foreach(KeyValuePair<string, int> entry in tillContents)
            {
                if (entry.Value != 0)
                {
                    string extractedKeyIntValue = String.Empty;
                    string extractedKeyCharValue = String.Empty;
                    char[] charArr = entry.Key.ToCharArray();
                    foreach (char c in charArr)
                    {
                        bool isCharInt = Char.IsNumber(c);

                        if (isCharInt)
                        {
                            extractedKeyIntValue += c.ToString();
                        }
                        else
                        {
                            extractedKeyCharValue += c.ToString();
                        }
                    }

                    string sumAllMonetaryPieces = (Convert.ToDouble(extractedKeyIntValue) * entry.Value).ToString();

                    if (extractedKeyCharValue == "p" && sumAllMonetaryPieces.Length <= 1)
                    {
                        totalSum += Convert.ToDouble($"0.0{Int32.Parse(sumAllMonetaryPieces)}");
                    }
                    else if (extractedKeyCharValue == "p" && sumAllMonetaryPieces.Length > 2)
                    {
                        totalSum += Convert.ToDouble($"{sumAllMonetaryPieces.Substring(0, sumAllMonetaryPieces.Length-2)}.{sumAllMonetaryPieces.Substring(sumAllMonetaryPieces.Length-2)}");
                    }
                    else if (extractedKeyCharValue == "£")
                    {
                        totalSum += Convert.ToDouble($"{Int32.Parse(sumAllMonetaryPieces)}.00");
                    }
                    else
                    {
                        totalSum += Convert.ToDouble($"0.{Int32.Parse(sumAllMonetaryPieces)}");
                    }
                }
            }
            return $"£{totalSum}";
        }
    }
}
