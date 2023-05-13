using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class KidsWithCandiesTests
    {

        [TestMethod]
        public void test1()
        {
            var sol = new KidsWithCandies();
            int[] candies = { 2, 8, 7 };
            int extraCandies = 1;

            var result = sol.KidsWithCandiesSol(candies, extraCandies);
        }
    }
}
