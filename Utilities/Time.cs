using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bs_Pro14.Utilities
{
    public class Time
    {
        private int hour, minute;

        public Time(int hour)
        {
            Hour = hour;
            Minute = 0;
        }

        public Time(int hour, int mintue)
        {
            Hour = hour;
            Minute = minute;
        }

        public int Hour
        {
            get { return hour; }
            set
            {
                if (value < 0 || value > 23)
                    throw new Exception("Hour must be between 0 to 23");
                else
                    hour = value;
            }
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0 || value > 59)
                    throw new Exception("Minute must be between 0 to 59");
                else
                    minute = value;
            }
        }

        public override string ToString()
        {
            string time = (hour < 10) ? "0" : "";
            time += hour.ToString() + ":";
            time += (minute < 10) ? "0" : "";
            time += minute;
            return time;
        }

        public static bool operator < (Time time1, Time time2)
        {
            if (time1.hour < time2.hour)
                return true;
            else if (time1.hour > time2.hour)
                return false;
            else if (time1.hour == time2.hour)
            {
                if (time1.minute < time2.minute)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator > (Time time1, Time time2)
        {
            if (time1.hour < time2.hour)
                return false;
            else if (time1.hour > time2.hour)
                return true;
            else if (time1.hour == time2.hour)
            {
                if (time1.minute <= time2.minute)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }

        public static bool operator == (Time time1, Time time2)
        {
            if (time1.hour == time2.hour && time1.minute == time2.minute)
                return true;
            else
                return false;
        }

        public static bool operator !=(Time time1, Time time2)
        {
            if (time1.hour != time2.hour || time1.minute != time2.minute)
                return true;
            else
                return false;
        }

        public static bool operator <=(Time time1, Time time2)
        {
            if (time1 < time2 || time1 == time2)
                return true;
            else
                return false;
        }

        public static bool operator >=(Time time1, Time time2)
        {
            if (time1 > time2 || time1 == time2)
                return true;
            else
                return false;
        }

        public static explicit operator Time(DateTime d)
        {
            Time t = new Time(d.Hour, d.Minute);
            return t;
        }

        public static bool coincidentTime(Time startTime1, Time endTime1, Time startTime2, Time endTime2)
        {
            if (startTime1 >= startTime2 && startTime1 < endTime2)
                return true;

            if (endTime1 > startTime2 && endTime1 <= endTime2)
                return true;

            return false;
        }

        public static bool containTime(Time startTime1, Time endTime1, Time startTime2, Time endTime2)
        {
            if (startTime1 <= startTime2 && endTime1 >= endTime2)
                return true;

            return false;
        }
    }
}
