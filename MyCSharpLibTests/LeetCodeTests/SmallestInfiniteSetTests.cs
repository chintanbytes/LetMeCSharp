using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class SmallestInfiniteSetTests
    {
        [TestMethod]
        public void SmallestInfiniteSetTest1()
        {
            var sol = new SmallestInfiniteSetLc();
            sol.AddBack(2);
            var x =sol.PopSmallest();
            x = sol.PopSmallest();
            x = sol.PopSmallest();
            sol.AddBack(1);
            x = sol.PopSmallest();
            x = sol.PopSmallest();
            x = sol.PopSmallest();
        }
    }
}
