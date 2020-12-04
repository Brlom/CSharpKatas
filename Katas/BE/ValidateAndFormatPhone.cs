using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.BE
{
    public class ValidateAndFormatPhone
    {
        public string SendToTwilio(string enteredVal)
        {
            if (!CheckIfValid(enteredVal))
            {
                return "Invalid phone number";
            }
            else
            {
                string formattedNum = FormatPhoneNum(enteredVal);
                return formattedNum;
            }
        }

        public bool CheckIfValid(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }
            else if (number.All(char.IsDigit) && number.Length == 11 && number.StartsWith("0"))
            {
                string chopZeroString = number.Substring(1);
                if (chopZeroString.StartsWith("1") || chopZeroString.StartsWith("2") || chopZeroString.StartsWith("7"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (number.All(char.IsDigit) && number.Length == 14 && number.StartsWith("0"))
            {
                string chopFirstTwo = number.Substring(2);
                if (chopFirstTwo.StartsWith("4"))
                {
                    string chopNextThree = chopFirstTwo.Substring(2);
                    if (chopNextThree.StartsWith("1") || chopNextThree.StartsWith("2") || chopNextThree.StartsWith("7"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (number.StartsWith("+") && number.Length == 13)
            {
                string chopFirstChar = number.Substring(1);
                string chopFirstThreeChars = number.Substring(3);
                if (chopFirstChar.StartsWith("4") && (chopFirstThreeChars.StartsWith("1") || chopFirstThreeChars.StartsWith("2") || chopFirstThreeChars.StartsWith("7")))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public string FormatPhoneNum(string validNum)
        {
            string chopFirstChar = validNum.Substring(1);
            string chopFirstThreeChars = validNum.Substring(3);

            if (validNum.All(char.IsDigit) && validNum.Length == 11 && validNum.StartsWith("0"))
            {
                return $"+44{chopFirstChar}";
            }
            else if (validNum.All(char.IsDigit) && validNum.Length == 14 && validNum.StartsWith("0"))
            {
                string chopZeroString = validNum.Substring(2);
                return $"+{chopZeroString}";
            }
            else if (validNum.Length == 13 && chopFirstChar.StartsWith("4") && (chopFirstThreeChars.StartsWith("1") || chopFirstThreeChars.StartsWith("2") || chopFirstThreeChars.StartsWith("7")))
            {
                return validNum;
            }
            else
            {
                return String.Empty;
            }
        }
    }
}
