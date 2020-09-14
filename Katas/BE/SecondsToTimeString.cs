using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace Katas.BE
{
    public class SecondsToTimeString
    {
        public string ConvertSecondsToString(double seconds)
        {
            var time = TimeSpan.FromSeconds(seconds);

            string years = Math.Floor(time.Days / 365.0).ToString();
            
            var x = time.Days;
            while (x >= 365)
            {
                x -= 365;
            }
            int count = 0;
            while (x >= 7)
            {
                x -= 7;
                count++;
            }
            string weeks = count.ToString();

            string days = (time.Days % 7).ToString();

            string hours = time.Hours.ToString();

            string minutes = time.Minutes.ToString();

            string finalSeconds = time.Seconds.ToString();

            string finalStr = String.Empty;


            if (years != "0")
            {
                finalStr += $"{years} {GetResultStr(years, "year")}";
            }
            if (weeks != "0")
            {
                finalStr += $" {weeks} {GetResultStr(weeks, "week")}";
            }
            if (days != "0")
            {
                finalStr += $" {days} {GetResultStr(days, "day")}";
            }
            if (hours != "0")
            {
                finalStr += $" {hours} {GetResultStr(hours, "hour")}";
            }
            if (minutes != "0")
            {
                finalStr += $" {minutes} {GetResultStr(minutes, "minute")}";
            }
            if (finalSeconds != "0")
            {
                finalStr += $" {finalSeconds} {GetResultStr(finalSeconds, "second")}";
            }

            return finalStr.TrimStart();
        }

        public string GetResultStr(string timeAmount, string timeSingular)
        {
            int time = int.Parse(timeAmount);
            if (time == 0)
            {
                return String.Empty;
            }
            else if (time == 1)
            {
                return timeSingular;
            }
            else
            {
                return $"{timeSingular}s";
            }
        }
    }
}
