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
            return enteredVal;
        }

        public bool CheckIfValid(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }
            else if (number.All(char.IsDigit))
            {

                return true;
            }
            return false;
        }

        public string FormatPhoneNum(string validNum)
        {
            return "";
        }
    }
}
