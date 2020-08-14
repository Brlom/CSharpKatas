using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.BE
{
    public delegate bool EvaluateInt(int x);

    public class EveryContainsSome
    {
        public bool Every(List<int> intList, EvaluateInt evaluate)
        {
            bool result = true;
            
            foreach (int item in intList)
            { 
                bool outcome = Evaluate(item);
                if (outcome == false)
                {
                    result = false;
                    break;
                }
            }
            
            return result;
        }

        public bool Contains(List<int> intList, int num)
        {
            bool result = false;

            foreach (int item in intList)
            {
                if (item == num)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool Some(List<Object> listToEvaluate)
        {
            bool result = false;
           
            foreach (Object item in listToEvaluate)
            {
                if (item is int && (int)item > 0)
                {
                    result = true;
                    break;
                }
                else if (item is double && (double)item > 0)
                {
                    result = true;
                    break;
                }
                else if (item is decimal && (decimal)item > 0)
                {
                    result = true;
                    break;
                }
                else if (item is float && (float)item > 0)
                {
                    result = true;
                    break;
                }
                else if (item is long && (long)item > 0)
                {
                    result = true;
                    break;
                }
                    else if (item is short && (short)item > 0)
                {
                    result = true;
                    break;
                }
                else if (item is bool && (bool)item == true)
                {
                    result = true;
                    break;
                }
                else if (item is string)
                {
                    result = true;
                    break;
                }
                else if (item is char)
                {
                    result = true;
                    break;
                }
                else if (item is DateTime)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool Evaluate(int num)
        {
            var result = false;

            if (num > 0)
            {
                result = num % 2 == 0;
            }

            return result;
        }
    }
}
