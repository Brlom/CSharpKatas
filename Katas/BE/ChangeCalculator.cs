using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.BE
{
    public class ChangeCalculator
    {
        public Dictionary<string, double> CalculateChange(double sumChangeDue)
        {
            var finalDict = new Dictionary<string, double>();
            var coins = new List<double>() { 50, 20, 10, 5, 2, 1 };
            double remainingChangeDue = sumChangeDue;
            
            foreach (double coin in coins)
            { 
                if(remainingChangeDue > 0)
                { 
                    double numCoins = 0;
                    if (remainingChangeDue - coin >= 0)
                    {
                        if (remainingChangeDue % coin == 0)
                        {
                            numCoins += remainingChangeDue / coin;
                            remainingChangeDue -= coin * numCoins;
                            finalDict.Add(coin.ToString(), numCoins);
                        }
                        else
                        { 
                            numCoins = (remainingChangeDue - (remainingChangeDue % coin)) / coin;
                            remainingChangeDue = remainingChangeDue%coin;
                            finalDict.Add(coin.ToString(), numCoins);
                        }
                    }
                }
            }

            return finalDict;
        }
    }
}
