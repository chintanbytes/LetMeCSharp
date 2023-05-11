using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class ReverseANumberTests
    {
        [TestMethod]
        public void ReverseANumberTest()
        {
            var sol = new ReverseANumber();
            var result =sol.Reverse(123);

            Assert.AreEqual(321, result, "Incorrect Result");

        }
    }
}
