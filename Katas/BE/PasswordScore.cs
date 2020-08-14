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

            string regex = @"\d+";

            string regExLessFour = @"\b\w{ 0,4}\b";
            string regExLessNine = @"\b\w{ 5,9}\b";
            string regExMoreEight = @"\b\w{ 8,}\b";

            //!@#$%^&*

            MatchCollection intMatches = Regex.Matches(password, regex);

            if (password.Length < 4 && password.Length > 0)
            {
                result = 1;
            }
            else if (password.Length > 3 && password.Length < 9)
            {
                result = 2;
            }
            else if (password.Length >= 9 && intMatches.Count < 1)
            {
                result = 3;
            }
            else if (password.Length >= 9 && intMatches.Count == 1)
            {
                result = 4;
            }

            return result;
        }
    }
}
