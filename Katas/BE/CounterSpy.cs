using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.BE
{
    public class CounterSpy
    {
        public List<string> RemoveSpies(List<string> providedList)
        {
            var finalList = new List<string>();
            foreach (string listItem in providedList)
            {
                var lowerItem = listItem.ToLower();
                if (lowerItem.Contains('y') || lowerItem.Contains('s') || lowerItem.Contains('y'))
                {
                    
                }
                else
                {
                    finalList.Add(listItem);
                }
            }
            return finalList;
        }
    }
}
