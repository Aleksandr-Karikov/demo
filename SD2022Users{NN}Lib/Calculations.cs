using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2022Users_NN_Lib
{
    public static class Calculations
    {
        static public string[] AvailablePeriods(
            TimeSpan[] startTimes,
            int[] durations,
            TimeSpan beginWorkingTime,
            TimeSpan endWorkingTime,
            int consultationTime
)
        {
            List<string> result = new List<string>();
            var timeInterval = new TimeSpan(0, consultationTime, 0);
            var begin = beginWorkingTime;
            var end = beginWorkingTime + timeInterval;

            while (begin <= endWorkingTime && end <= endWorkingTime)
            {
                var flag = true;
                for (int i = 0; i < startTimes.Length; i++)
                {
                    var startTime = startTimes[i];
                    var endTime = new TimeSpan(0, durations[i], 0) + startTime;
                    if ((begin >= startTime && begin < endTime) || (end <= endTime && end > startTime))
                    {
                        flag = false;
                        begin = endTime;
                        end = begin + timeInterval;
                        break;
                    }
                }
                if (flag)
                {
                    result.Add(begin.ToString("hh\\:mm") + " - " + end.ToString("hh\\:mm"));
                    begin = end;
                    end += timeInterval;
                }
               
            }
            return result.ToArray();

        }
    }
}
