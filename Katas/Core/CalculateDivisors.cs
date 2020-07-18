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
