using MyCSharpLib.Enums;

namespace MyCSharpLib.ExtensionMethods
{
    public static class DaysEnumExtensionMethods
    {
        public static bool IsWeekday(this Days day)
        {
            return day is Days.Monday or Days.Tuesday or Days.Wednesday or Days.Thursday or Days.Friday;
        }

        public static bool IsWeekend(this Days day)
        {
            return day is Days.Saturday or Days.Sunday;
        }
    }
}