using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class ReverseWordsProblemTests
    {
        [TestMethod]
        public void TestReserveWords()
        {
            var sol = new ReverseWordsProblem();
            var result = sol.ReserveWords("the sky is blue");
            Assert.AreEqual("blue is sky the", result);
        }

    }
}
