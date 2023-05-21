using MyCSharpLib.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class EqualPairsTests
    {
        [TestMethod]
        public void EqualPairsTest()
        {
            var lc = new EqualPairsLc();
            var grid = new int[][]
                { new[] { 3, 1, 2, 2 }, new[] { 1, 4, 4, 5 }, new[] { 2, 4, 2, 2 }, new[] { 2, 4, 2, 2 } };
            var count = lc.EqualPairs(grid);
            Assert.AreEqual(3, count);

        }
    }
}
