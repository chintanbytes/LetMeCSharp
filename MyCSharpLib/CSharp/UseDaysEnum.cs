using MyCSharpLib.Enums;
using MyCSharpLib.ExtensionMethods;
using System;

namespace MyCSharpLib.CSharp
{
    public class UseDaysEnum
    {
        public event EventHandler<Days>? DayChanged; 
        public UseDaysEnum(Days day) => Today = day;

        public Days Today { get; private set; }

        public void NextDay()
        {
            if(Today == Days.Sunday)
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
    }
}