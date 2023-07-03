using MyCSharpLib.Enums;
using MyCSharpLib.ExtensionMethods;
using System;

namespace MyCSharpLib.CSharp
{
    public class DayEventArgs : EventArgs
    {
        public DayEventArgs(Days day)
        { 
            Day = day;
        }

        public Days Day { get; private set; }
    }
    
    public class UseDaysEnum
    {
        public delegate void DayEventHandler(object sender, DayEventArgs e);
        public event EventHandler<DayEventArgs> DayChanged;

        public event DayEventHandler DayEvt;
        public event EventHandler DayEvt1;
        public UseDaysEnum(Days day) => Today = day;

        public Days Today { get; private set; }

        public void NextDay()
        {
            if (Today == Days.Sunday)
                Today = Days.Monday;
            else
                Today = (Days)((int)Today << 1);
            OnDayChanged();
        }

        public bool AmIWorkingToday()
        {
            return (Days)((int)Today & (int)Days.Weekday) == Today;
            //return Today.IsWeekday();
        }

        public bool CanIRelaxToday()
        {
            return (Days)((int)Today & (int)Days.Weekend) == Today;
            //return Today.IsWeekend();
        }

        protected virtual void OnDayChanged()
        {
            DayChanged?.Invoke(this, new DayEventArgs(Today));
            DayEvt?.Invoke(this, new DayEventArgs(Today));
            DayEvt1?.Invoke(this, new DayEventArgs(Today));
        }

        /// <summary>
        /// Is Weekend using pattern matching with switch
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool IsWeekend(Days day) =>
            day switch
            {
                Days.Monday or Days.Tuesday or Days.Wednesday or Days.Thursday or Days.Friday => false,
                Days.Saturday or Days.Sunday => true,
                _ => throw new Exception("Invalid Day")
            };
    }
}