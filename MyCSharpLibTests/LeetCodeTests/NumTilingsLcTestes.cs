using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class NumTilingsLcTestes
    {
        [TestMethod]
        public void NumTilingsTest()
        {
            var sol = new NumTilingsLc();
            var result = sol.NumTilings(3);
            Assert.AreEqual(5, result);
        }
    }
}
