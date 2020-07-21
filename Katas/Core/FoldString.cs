using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas.Core
{
    public class FoldString
    {
        public string StringFolder(string str)
        {
            if (str == String.Empty)
            {
                return str;
            }

            Regex punctuation = new Regex(@"[.,!?]");
            if (punctuation.IsMatch(str))
            { 
            
            }

            string newStr = String.Empty;
            string[] splitStr = str.Split(" ");

            foreach (string word in splitStr)
            { 
                if (word.Length % 2 == 0)
                {
                    string firstHalf = word.Substring(0, word.Length / 2);
                    string secondHalf = word.Substring(word.Length / 2);

                    char[] firstArr = firstHalf.ToCharArray();
                    char[] secondArr = secondHalf.ToCharArray();

                    Array.Reverse(firstArr);
                    Array.Reverse(secondArr);

                    string backStrFirst = new string(firstArr);
                    string backStrSecond = new string(secondArr);

                    newStr += backStrFirst + backStrSecond + " ";
                }   
                else 
                {
                    string oddFirstHalf = word.Substring(0, word.Length / 2);
                    string oddSecondHalf = word.Substring(word.Length / 2 + 1);
                    string middle = word.Substring(word.Length/2).Substring(0, 1);

                    char[] oddFirstArr = oddFirstHalf.ToCharArray();
                    char[] oddSecondArr = oddSecondHalf.ToCharArray();

                    Array.Reverse(oddFirstArr);
                    Array.Reverse(oddSecondArr);

                    string convertToStringOddFirst = new string(oddFirstArr);
                    string convertToStringOddSecond = new string(oddSecondArr);

                    newStr += convertToStringOddFirst + middle + convertToStringOddSecond + " ";
                }
            }

            return newStr.Trim(' ');
        }

    }
}
