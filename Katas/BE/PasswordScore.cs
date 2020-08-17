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

            //string regExInt = @"\d+";

            //!@#$%^&*

            //MatchCollection lessNineMatches = Regex.Matches(password, regExLessNine);
            //MatchCollection moreEightMatches = Regex.Matches(password, regExMoreEight);

            if (Regex.IsMatch(password, @"\b[a-z]{0,3}\b"))
            {
                result = 1;
            }
            else if (Regex.IsMatch(password, @"\b[a-z]{4,8}\b"))
            {
                result = 2;
            }
            else if (Regex.IsMatch(password, @"\b[a-z]{9,}\b"))
            {
                result = 3;
            }
            //else if (password.Length >= 9 && intMatches.Count == 1)
            //{
            //    result = 4;
            //}

            return result;
        }
    }
}
