using MyCSharpLib.Enums;
using MyCSharpLib.ExtensionMethods;
using System;

namespace MyCSharpLib.CSharp
{
    public class UseDaysEnum
    {
        public event EventHandler<Days> DayChanged;
        public UseDaysEnum(Days day) => Today = day;

        public Days Today { get; private set; }

        public void NextDay()
        {
            if (Today == Days.Sunday)
                Today = Days.Monday;
            else
                Today++;
            OnDayChanged();
        }

        public bool AmIWorkingToday()
        {
            return Today.IsWeekday();
        }

        public bool CanIRelaxToday()
        {
            return Today.IsWeekend();
        }

        protected virtual void OnDayChanged()
        {
            DayChanged?.Invoke(this, Today);
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