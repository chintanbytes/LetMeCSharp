using MyCSharpLib.CSharp;
using MyCSharpLib.Enums;
using System;

namespace MyCSharpLibTests.CSharpTests
{
    [TestClass]
    public class UseDaysEnumTests
    {
        [TestMethod]
        public void OnMondayIHaveToWork()
        {
            UseDaysEnum myClass = new (Days.Monday);
            Assert.IsTrue(myClass.AmIWorkingToday());
        }

        [TestMethod]
        public void OnWeekendICanRelax()
        {
            UseDaysEnum myClass = new(Days.Saturday);
            myClass.DayChanged += ItsSundayNow;

            Assert.IsTrue(myClass.CanIRelaxToday());
            myClass.NextDay();
            Assert.IsTrue(myClass.CanIRelaxToday());
        }

        private static void ItsSundayNow(object sender, DayEventArgs e)
        {
            Assert.AreEqual(Days.Sunday, e.day);
        }

        [TestMethod]
        public void TestSaturdayIsAWeekendWithSwitchPatternMatching()
        {
            Assert.IsTrue(UseDaysEnum.IsWeekend(Days.Saturday));
        }

        [TestMethod]
        public void TestSundayIsAWeekendWithSwitchPatternMatching()
        {
            Assert.IsTrue(UseDaysEnum.IsWeekend(Days.Sunday));
        }

        [TestMethod]
        public void TestMondayIsNotAWeekendWithSwitchPatternMatching()
        {
            Assert.IsFalse(UseDaysEnum.IsWeekend(Days.Monday));
        }
    }
}
