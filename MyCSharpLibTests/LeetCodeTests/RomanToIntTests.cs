using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class RomanToIntTests
    {
        private RomanToIntProblem _problem;

        [TestInitialize]
        public void setup()
        {
            _problem = new ();
        }

        [TestMethod]
        public void TestRomanToInt()
        {
            var number = _problem.RomanToInt("XXXI");
            Assert.AreEqual(31, number);

            number = _problem.RomanToInt("III");
            Assert.AreEqual(3, number);

            number = _problem.RomanToInt("LVIII");
            Assert.AreEqual(58, number);

            number = _problem.RomanToInt("MCMXCIV");
            Assert.AreEqual(1994, number);
        }

        [TestMethod]
        public void TestRomanToIntUsingDictionary()
        {
            var number = _problem.RomanToIntUsingDictionary("XXXI");
            Assert.AreEqual(31, number);

            number = _problem.RomanToIntUsingDictionary("III");
            Assert.AreEqual(3, number);

            number = _problem.RomanToIntUsingDictionary("LVIII");
            Assert.AreEqual(58, number);

            number = _problem.RomanToIntUsingDictionary("MCMXCIV");
            Assert.AreEqual(1994, number);
        }
    }
}
