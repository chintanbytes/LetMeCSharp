using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class HouseRobberLcTests
    {
        [TestMethod]
        public void HouseRobberLcTets()
        {
            var sol = new HouseRobberLc();
            var result = sol.Rob(new int[] { 1, 2, 3, 1 });
        }
    }
}
