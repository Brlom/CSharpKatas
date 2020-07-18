using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas.Core
{
    public class PigLatin
    {

        public string PigLatinKata(string originalStr)
        {
            if (originalStr == String.Empty)
            {
                return originalStr;
            }

            string[] wordsInStr = originalStr.Split(' ');
            string pigLatinStr = String.Empty;
            string appendage = String.Empty;

            foreach (string word in wordsInStr)
            {
                string newStr = String.Empty;
                char[] charArr = word.ToCharArray();
                char firstChar = charArr[0];
                string punctuationStr = String.Empty;
                string wordWithoutPunct = word;
                int count = 0;

                Regex punctuation = new Regex(@"[.,!?]");

                if (punctuation.IsMatch(word))
                {
                    punctuationStr = charArr.Last().ToString();
                    wordWithoutPunct = word.Substring(0, word.Length - 1);
                }

                switch (Char.ToLower(firstChar))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        pigLatinStr += wordWithoutPunct + "way" + punctuationStr + ' ';
                        break;
                    default:
                        foreach (char ch in charArr)
                        {
                            Regex rgx = new Regex(@"[^aeiouAEIOU]+");
                            if (rgx.IsMatch(ch.ToString()))
                            {
                                newStr += ch;
                                appendage = "ay";
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        pigLatinStr += wordWithoutPunct.Substring(count) + newStr + appendage + punctuationStr + ' ';
                        break;
                }
            }

            return pigLatinStr.TrimEnd(' ');
        }
    }
}
