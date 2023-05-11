using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class MergeAlternatelyTests
    {

        [TestMethod]
        public void MergeAlternatelyTest()
        {
            var sol = new MergeAlternatelyProblem();
            var result = sol.MergeAlternately("abc", "pqr");
        }
    }
}
