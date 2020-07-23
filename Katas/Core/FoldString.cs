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

            string newStr = String.Empty;
            string[] splitStr = str.Split(" ");

            foreach (string word in splitStr)
            {
                Regex punctuation = new Regex(@"[.,!?]");
                string punctuationToAdd = String.Empty;
                string wordWithoutPunctuation = word;

                if (punctuation.IsMatch(word))
                {
                    punctuationToAdd += word[word.Length - 1];
                    wordWithoutPunctuation = word.Substring(0, word.Length - 1);
                }
                
                if (wordWithoutPunctuation.Length % 2 == 0)
                {
                    string firstHalf = wordWithoutPunctuation.Substring(0, wordWithoutPunctuation.Length / 2);
                    string secondHalf = wordWithoutPunctuation.Substring(wordWithoutPunctuation.Length / 2);

                    char[] firstArr = firstHalf.ToCharArray();
                    char[] secondArr = secondHalf.ToCharArray();

                    Array.Reverse(firstArr);
                    Array.Reverse(secondArr);

                    string backStrFirst = new string(firstArr);
                    string backStrSecond = new string(secondArr);

                    newStr += backStrFirst + backStrSecond + punctuationToAdd + " ";
                }   
                else 
                {
                    string oddFirstHalf = wordWithoutPunctuation.Substring(0, wordWithoutPunctuation.Length / 2);
                    string oddSecondHalf = wordWithoutPunctuation.Substring(wordWithoutPunctuation.Length / 2 + 1);
                    string middle = wordWithoutPunctuation.Substring(wordWithoutPunctuation.Length/2).Substring(0, 1);

                    char[] oddFirstArr = oddFirstHalf.ToCharArray();
                    char[] oddSecondArr = oddSecondHalf.ToCharArray();

                    Array.Reverse(oddFirstArr);
                    Array.Reverse(oddSecondArr);

                    string convertToStringOddFirst = new string(oddFirstArr);
                    string convertToStringOddSecond = new string(oddSecondArr);

                    newStr += convertToStringOddFirst + middle + convertToStringOddSecond + punctuationToAdd + " ";
                }
            }

            return newStr.Trim(' ');
        }

    }
}
