using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class MaxAreaLcTests
    {
        [TestMethod]
        public void MaxAreaTest1()
        {
            var sol = new MaxAreaLc();
            var area =  sol.MaxArea(new[] { 2, 3, 4, 5, 18, 17, 6 });
            Assert.AreEqual(17, area);
        }
    }
}
