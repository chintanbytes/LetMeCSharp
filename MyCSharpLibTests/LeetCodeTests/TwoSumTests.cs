using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class TowSumTests
    {
        private TwoSumProblem towSum;
        private int[] array;
        private int target;

        [TestInitialize]
        public void setup()
        {
            towSum = new TwoSumProblem();
            array = new[] { 1, 2, 3 };
            target = 5;
        }

        [TestMethod]
        public void TestTwoSum()
        {
            var result = towSum.TowSum(array, target);
            Assert.AreEqual(1, result[0], "Did not match first index");
            Assert.AreEqual(2, result[1], "Did not match second index");
        }
    }
}