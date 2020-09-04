using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.BE
{
    public class SecondsToTimeString
    {
        public string ConvertSecondsToString(double seconds)
        {
            double remainingSeconds = seconds;
            string finalStr = String.Empty;

            string resultHourStr = "hours";
            string resultMinuteStr = "minutes";
            string resultSecondStr = "seconds";
            double resultHours = 0;
            double resultMinutes = 0;
            double resultSeconds = 0;

            while (remainingSeconds > 0)
            {
                if (remainingSeconds > 3600)
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
                else if (remainingSeconds > 60)
                {
                    double secondsLeftAfterMinDeducted = remainingSeconds % 60;
                    resultMinutes = (remainingSeconds - secondsLeftAfterMinDeducted) / 60;
                    if (resultMinutes == 1)
                    {
                        resultMinuteStr = "minute";
                    }
                    else
                    {
                        resultMinuteStr = "minutes";
                    }
                    remainingSeconds -= resultMinutes * 60;
                }
                else if (remainingSeconds == 60)
                {
                    resultMinutes = remainingSeconds / 60;
                    resultMinuteStr = "minute";
                    remainingSeconds -= remainingSeconds;
                }
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

            if (resultHours > 0)
            {
                finalStr = $"{resultHours} {resultHourStr} {resultMinutes} {resultMinuteStr} {resultSeconds} {resultSecondStr}";
            }
            else if (resultHours == 0)
            {
                if (resultMinutes == 0)
                {
                    finalStr += $"{resultSeconds} {resultSecondStr}";
                }
                else
                {
                    finalStr = $"{resultMinutes} {resultMinuteStr} {resultSeconds} {resultSecondStr}";
                }
            }
            else
            {
                finalStr = $"{resultSeconds} {resultSecondStr}";
            }

            return finalStr;
        }
    }
}
