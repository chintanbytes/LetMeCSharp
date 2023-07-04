using MyCSharpLib.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class SpiralMatrixLcTests
    {

        [TestMethod]
        public void SpiralMatrixLcTest1()
        {
            var sol = new SpiralMatrixLc();
            var matrix = sol.GenerateMatrix(3);
        }
    }
}
