using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class ReorderRoutesTests
    {
        [TestMethod]
        public void TestReorderRoutes()
        {
            var sol = new ReorderRoutesLc();
            var connections = new[]
                { new[] { 1, 2 }, new[] { 2, 0 } };
            var result = sol.MinReorder(3, connections);
            Assert.AreEqual(0, result);
        }
    }
}



//1 -> 2 -> 0