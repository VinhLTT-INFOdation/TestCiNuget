using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MaxV.Helper
{
    public static class StopWatchHelper
    {
        public static Stopwatch StartStopwatch()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            return sw;
        }

        public static string StopAndReturnElapsedTime(Stopwatch sw)
        {
            sw.Stop();

            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.TotalHours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            return elapsedTime;
        }
    }
}
