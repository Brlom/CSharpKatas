using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.BE.BE2
{
    public class InsertNewValue
    {
        public List<int> AddNewValueToList(List<int> intList, int intToAdd)
        {
            // is list odd or even number
            // if odd, we can find int in middle of list
            // we then compare intToAdd with middle int
            // if intToAdd is less than middle int, then keep everything to left of middle int and do same again until false
            
            
            return new List<int>();
        }

        public int BinarySearch(List<int> intList, int first, int last, int toAdd)
        {
            int middle = first + last / 2;
            if (middle > toAdd)
            {
                return BinarySearch(intList, first, middle, toAdd);
            }
            else if (middle < toAdd)
            {
                return BinarySearch(intList, middle, last, toAdd);
            }
        }
    }
}

// [1, 3, 4, 5, 6]
// toAdd = 2;
