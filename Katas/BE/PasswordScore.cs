using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas.BE
{
    public class PasswordScore
    {
        public double GetPasswordScore(string password)
        {
            int result = 0;

            string regExInt = @"\d";
            string regExSpecChar = @"[!@£#$%^&*\\]";

            MatchCollection intCheck = Regex.Matches(password, regExInt);
            MatchCollection specCharCheck = Regex.Matches(password, regExSpecChar);

            if (password.Length > 0 && password.Length < 4)
            {
                result = 1;
            }
            else if (password.Length >= 4 && password.Length < 9)
            {
                result = 2;
            }
            else if (password.Length >= 9 && password.Length < 12)
            {
                if (intCheck.Count != 0 && specCharCheck.Count != 0)
                {
                    result = 5;
                }
                else if (intCheck.Count != 0)
                {
                    result = 4;
                }
                else
                {
                    result = 3;
                }
            }
            else if (password.Length >= 12)
            {
                if (intCheck.Count != 0 && specCharCheck.Count != 0)
                {
                    result = 7;
                }
                else if (intCheck.Count != 0)
                {
                    result = 6;
                }
                else
                {
                    result = 3;
                }
            }
           
            return result;
        }
    }
}
