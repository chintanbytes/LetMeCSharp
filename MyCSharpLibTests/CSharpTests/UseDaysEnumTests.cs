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
            myClass.DayEvt += MyClass_DayEvt;
            myClass.DayEvt1 += MyClass_DayEvt1;

            Assert.IsTrue(myClass.CanIRelaxToday());
            myClass.NextDay();
            Assert.IsTrue(myClass.CanIRelaxToday());
            
        }

        private void MyClass_DayEvt(object sender, DayEventArgs e)
        {
            Assert.AreEqual(Days.Sunday, e.Day);
        }

        private void MyClass_DayEvt1(object sender, EventArgs e)
        {
            Assert.AreEqual(Days.Sunday, Days.Sunday);
        }

        private static void ItsSundayNow(object sender, DayEventArgs e)
        {
            Assert.AreEqual(Days.Sunday, e.Day);
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
