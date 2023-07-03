using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCSharpLib.CSharp;

namespace MyCSharpLibTests.CSharpTests
{
    [TestClass]
    public class CSharpTests
    {
        [TestMethod]
        public void CSharTest1()
        {
            var cs = new CSharp(0, 1 );
            var(num1, num2) = cs;

            Assert.AreEqual(num1, 0);
            Assert.AreEqual(num2, 1);
            Assert.IsFalse(cs.AreNumberEqual());
        }
    }
}
