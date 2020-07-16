using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.Core
{
    public class CalculateDivisors
    {
        public int CalculateDivisor(int startingNum)
        {
            int sumDivisibleNums = 0;
            // we want to get a list of numbers starting with startingNum and working backwards
            // we want to go through each number in list to check if it/3 or it/5 = int
            // if divided num is a round number, add to sumTotal

            IEnumerable<int> numsBetweenStartingNumAndZero = Enumerable.Range(0, startingNum);

            foreach (int num in numsBetweenStartingNumAndZero)
            {
                if (num % 5 == 0 || num % 3 == 0)
                {
                    sumDivisibleNums += num;
                }
            }

            return sumDivisibleNums;
        }
    }
}
