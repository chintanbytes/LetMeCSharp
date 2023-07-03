using MyCSharpLib.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class TargetSumLcTests
    {
        [TestMethod]
        public void TargetSumLcTest1()
        {
            var sol = new TargetSumLc();
            var result = sol.FindTargetSumWays(new int[] { 1, 1, 1, 1, 1 }, 3);
            Assert.AreEqual(5,result);
        }
    }
}
