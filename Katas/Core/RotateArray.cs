using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Core
{
    public class RotateArray
    {
        public List<int> RotateListElements(List<int> intList, int numRotations)
        {
            var itemsToKeep = new List<int>();
            var itemsToRotate = new List<int>();

            var finalList = new List<int>();
            int actualRotations = (Math.Abs(numRotations) > intList.Count) ? Math.Abs(numRotations) % intList.Count : Math.Abs(numRotations);
            int removeFirst = intList.Count - actualRotations;

            foreach (int i in intList)
            {
                itemsToKeep.Add(i);
                itemsToRotate.Add(i);
            }

            if (numRotations >= 0 && intList.Count < 2)
            {
                return intList;
            }

            if (numRotations < 0)
            {
                itemsToRotate.RemoveRange(actualRotations, removeFirst);
                itemsToKeep.RemoveRange(0, actualRotations);

                foreach (int i in itemsToKeep)
                {
                    finalList.Add(i);
                }

                foreach (int i in itemsToRotate)
                {
                    finalList.Add(i);
                }

            }
            else
            {
                itemsToKeep.RemoveRange(removeFirst, actualRotations);
                itemsToRotate.RemoveRange(0, removeFirst);

                foreach (int i in itemsToRotate)
                {
                    finalList.Add(i);
                }

                foreach (int i in itemsToKeep)
                {
                    finalList.Add(i);
                }
            }

            return finalList;
        }
    }
}
