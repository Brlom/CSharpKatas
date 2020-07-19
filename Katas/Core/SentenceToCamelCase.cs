using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit.Sdk;

namespace Katas.Core
{
    public class SentenceToCamelCase
    {
        public string ConvertToCamelCase(string strToConvert, bool upperOrLower)
        {
            if (strToConvert == "")
            {
                return strToConvert;
            }

            TextInfo ti = new CultureInfo("en-GB", false).TextInfo;
            string[] wordArr = strToConvert.Split(" ");
            string newStr = String.Empty;

            if (upperOrLower)
            {
                foreach (string word in wordArr)
                {
                    newStr += ti.ToTitleCase(word);
                }
            }
            else
            {
                newStr += wordArr[0];
                foreach (string word in wordArr)
                {
                    if (word != wordArr[0])
                    {
                        newStr += ti.ToTitleCase(word);
                    }
                }
            }
            return newStr;
        }

        public string ConvertToEnglish(string strToConvert)
        {
            if(strToConvert == "")
            {
                return strToConvert;
            }

            char[] charArr = strToConvert.ToCharArray();
            string newStr = String.Empty;
            Regex uppercase = new Regex(@"[A-Z]");

            foreach(Char ch in charArr)
            {
                if (uppercase.IsMatch(ch.ToString()) && ch != charArr[0])
                {
                    newStr += " " + ch;
                }
                else
                {
                    newStr += ch;
                }
            }

            string[] wordArr = newStr.Split(" ");
            string returningStr = String.Empty;

            TextInfo ti = new CultureInfo("en-GB", false).TextInfo;
            returningStr += ti.ToTitleCase(wordArr[0]);

            foreach (string word in wordArr)
            {
                if (word != wordArr[0])
                {
                    returningStr += " " + word.ToLower();
                }
            }

            return returningStr;
        }
    }
}
