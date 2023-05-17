using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class FindMaxAverageProblemTests
    {
        [TestMethod]
        public void FindMaxAverageTest()
        {
            var prob = new FindMaxAverageProblem();
            var arr = new []{ 0, 4, 0, 3, 2 };
            var result = prob.FindMaxAverage(arr, 1);
            Assert.AreEqual(4, result);
        }
    }
}
