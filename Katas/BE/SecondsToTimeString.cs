using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.BE
{
    public class SecondsToTimeString
    {
        public string ConvertSecondsToString(double seconds)
        {
            var time = TimeSpan.FromSeconds(seconds);
            //return @"{something.Days} days";

            double remainingSeconds = seconds;
            string finalStr = String.Empty;

            string resultYearStr = "years";
            string resultWeekStr = "weeks";
            string resultDayStr = "days";
            string resultHourStr = "hours";
            //string resultMinuteStr = "minutes";
            string resultSecondStr = "seconds";

            double resultYears = 0;
            double resultWeeks = 0;
            double resultDays = 0;
            double resultHours = 0;
            //double resultMinutes = 0;
            double resultSeconds = 0;

            string minutes = String.Empty;

            while (remainingSeconds > 0)
            {
                if (remainingSeconds > 31449600)
                {
                    double secondsLeftAfterYearDeducted = remainingSeconds % 31449600;
                    resultYears = (remainingSeconds - secondsLeftAfterYearDeducted) / 31449600;
                    if (resultYears == 1)
                    {
                        resultYearStr = "year";
                    }
                    else
                    {
                        resultYearStr = "years";
                    }
                    remainingSeconds -= resultYears * 31449600;
                }
                else if (remainingSeconds == 31449600)
                {
                    resultYears = remainingSeconds / 31449600;
                    resultYearStr = "year";
                    remainingSeconds -= remainingSeconds;
                }
                else if (remainingSeconds > 604800)
                {
                    double secondsLeftAfterWeekDeducted = remainingSeconds % 604800;
                    resultWeeks = (remainingSeconds - secondsLeftAfterWeekDeducted) / 604800;
                    if (resultWeeks == 1)
                    {
                        resultWeekStr = "week";
                    }
                    else
                    {
                        resultWeekStr = "weeks";
                    }
                    remainingSeconds -= resultWeeks * 604800;
                }
                else if (remainingSeconds == 604800)
                {
                    resultWeeks = remainingSeconds / 604800;
                    resultWeekStr = "week";
                    remainingSeconds -= remainingSeconds;
                }
                else if (remainingSeconds > 86400)
                {
                    double secondsLeftAfterDayDeducted = remainingSeconds % 86400;
                    resultDays = (remainingSeconds - secondsLeftAfterDayDeducted) / 86400;
                    if (resultDays == 1)
                    {
                        resultDayStr = "day";
                    }
                    else
                    {
                        resultDayStr = "days";
                    }
                    remainingSeconds -= resultDays * 86400;
                }
                else if (remainingSeconds == 86400)
                {
                    resultDays = remainingSeconds / 86400;
                    resultDayStr = "day";
                    remainingSeconds -= remainingSeconds;
                }
                else if (remainingSeconds > 3600)
                {
                    double secondsLeftAfterHourDeducted = remainingSeconds % 3600;
                    resultHours = (remainingSeconds - secondsLeftAfterHourDeducted) / 3600;
                    if (resultHours == 1)
                    {
                        resultHourStr = "hour";
                    }
                    else
                    {
                        resultHourStr = "hours";
                    }
                    remainingSeconds -= resultHours * 3600;
                }
                else if (remainingSeconds == 3600)
                {
                    resultHours = remainingSeconds / 3600;
                    resultHourStr = "hour";
                    remainingSeconds -= remainingSeconds;
                }
                else if (remainingSeconds >= 60)
                {
                    //double secondsLeftAfterMinDeducted = remainingSeconds % 60;
                    //resultMinutes = (remainingSeconds - secondsLeftAfterMinDeducted) / 60;
                    //if (resultMinutes == 1)
                    //{
                    //    resultMinuteStr = "minute";
                    //}
                    //else
                    //{
                    //    resultMinuteStr = "minutes";
                    //}

                    //return @"{something.Days} days";
                    double resultMinutes = Math.Floor(Decimal.ToDouble(time.Minutes));
                    string resultMinuteStr = GetResultStr(resultMinutes, "minute");

                    if (resultMinutes == 0)
                    {
                        minutes = String.Empty;
                    }
                    else
                    {
                        minutes = $"{resultMinutes.ToString()} {resultMinuteStr}";
                    }
                    
                    remainingSeconds -= resultMinutes * 60;
                }
                //else if (remainingSeconds == 60)
                //{
                //    resultMinutes = remainingSeconds / 60;
                //    //resultMinuteStr = "minute";
                //    remainingSeconds -= remainingSeconds;
                //}
                else if (remainingSeconds > 1 && remainingSeconds < 60)
                {
                    resultSeconds = remainingSeconds;
                    resultSecondStr = "seconds";
                    remainingSeconds -= remainingSeconds;
                }
                else if (remainingSeconds == 1)
                {
                    resultSeconds = remainingSeconds;
                    resultSecondStr = "second";
                    remainingSeconds -= 1;
                }
            }

            if (resultYears > 0)
            {
                finalStr = $"{resultYears} {resultYearStr} {resultWeeks} {resultWeekStr} {resultDays} {resultDayStr} {resultHours} {resultHourStr} {minutes} {resultSeconds} {resultSecondStr}";
            }
            else if (resultYears == 0)
            {
                if (resultWeeks == 0)
                {
                    if (resultDays == 0)
                    {
                        if (resultHours == 0)
                        {
                            if (minutes == String.Empty)
                            {
                                finalStr += $"{resultSeconds} {resultSecondStr}";
                            }
                            else
                            {
                                finalStr = $"{minutes} {resultSeconds} {resultSecondStr}";
                            }
                        }
                        else
                        {
                            finalStr = $"{resultHours} {resultHourStr} {minutes} {resultSeconds} {resultSecondStr}";
                        }
                    }
                    else
                    {
                        finalStr = $"{resultDays} {resultDayStr} {resultHours} {resultHourStr} {minutes} {resultSeconds} {resultSecondStr}";
                    }
                }
                else {
                    finalStr = $"{resultWeeks} {resultWeekStr} {resultDays} {resultDayStr} {resultHours} {resultHourStr} {minutes} {resultSeconds} {resultSecondStr}";
                }
            }
            else if (resultWeeks > 0)
            {
                finalStr = $"{resultWeeks} {resultWeekStr} {resultDays} {resultDayStr} {resultHours} {resultHourStr} {minutes} {resultSeconds} {resultSecondStr}";
            }
            else if (resultWeeks == 0)
            {
                if (resultDays == 0)
                {
                    if (resultHours == 0)
                    {
                        if (minutes == String.Empty)
                        {
                            finalStr += $"{resultSeconds} {resultSecondStr}";
                        }
                        else
                        {
                            finalStr = $"{minutes} {resultSeconds} {resultSecondStr}";
                        }
                    }
                    else
                    {
                        finalStr = $"{resultHours} {resultHourStr} {minutes} {resultSeconds} {resultSecondStr}";
                    }
                }
                else
                {
                    finalStr = $"{resultDays} {resultDayStr} {resultHours} {resultHourStr} {minutes} {resultSeconds} {resultSecondStr}";
                }
            }
            else if (resultDays > 0)
            {
                finalStr = $"{resultDays} {resultDayStr} {resultHours} {resultHourStr} {minutes} {resultSeconds} {resultSecondStr}";
            }
            else if (resultDays == 0)
            {
                if (resultHours == 0)
                {
                    if (minutes == String.Empty)
                    {
                        finalStr += $"{resultSeconds} {resultSecondStr}";
                    }
                    else
                    {
                        finalStr = $"{minutes} {resultSeconds} {resultSecondStr}";
                    }
                }
                else
                {
                    finalStr = $"{resultHours} {resultHourStr} {minutes} {resultSeconds} {resultSecondStr}";
                }
            }
            else if (resultHours > 0)
            {
                finalStr = $"{resultHours} {resultHourStr} {minutes} {resultSeconds} {resultSecondStr}";
            }
            else if (resultHours == 0)
            {
                if (minutes == String.Empty)
                {
                    finalStr += $"{resultSeconds} {resultSecondStr}";
                }
                else
                {
                    finalStr = $"{minutes} {resultSeconds} {resultSecondStr}";
                }
            }
            else
            {
                finalStr = $"{resultSeconds} {resultSecondStr}";
            }

            return finalStr;
        }

        public string GetResultStr(double timeAmount, string timeSingular)
        {
            if (timeAmount == 0)
            {
                return String.Empty;
            }
            else if (timeAmount == 1)
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
