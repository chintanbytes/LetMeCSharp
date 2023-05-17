using System;
using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class ProductExceptSelfTests
    {

        [TestMethod]
        public void TestProductExceptSelf1()
        {
            var cls = new ProductExceptSelfProblem();
            var arr = new[] { 1, 2, 3, 4 };
            var result = cls.ProductExceptSelf(arr);
        }

        [TestMethod]
        public void TestProductExceptSelf2()
        {
            var cls = new ProductExceptSelfProblem();
            var arr = new[] { -1, 1, 0, -3, 3 };
            var result = cls.ProductExceptSelf(arr);

        }
    }
}
