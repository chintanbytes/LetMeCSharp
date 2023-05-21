using System.Linq;
using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class FindDifferenceTests
    {
        [TestMethod]
        public void FindDifferenceLcTest()
        {
            var LC = new FindDifferenceLc();
            var nums1 = new int[] { 1, 2, 3 };
            var nums2 = new int[] { 2, 4, 6 };
            var result = LC.FindDifference(nums1, nums2);

            Assert.AreEqual(1, result.ElementAt(0).ElementAt(0));
            Assert.AreEqual(3, result.ElementAt(0).ElementAt(1));

            Assert.AreEqual(4, result.ElementAt(1).ElementAt(0));
            Assert.AreEqual(6, result.ElementAt(1).ElementAt(1));
        }

        [TestMethod]
        public void FindDifferenceLcTest1()
        {
            var LC = new FindDifferenceLc();
            var nums1 = new int[] { 1, 2, 3, 3 };
            var nums2 = new int[] { 1, 1, 2, 2 };
            var result = LC.FindDifference(nums1, nums2);

            Assert.AreEqual(3, result.ElementAt(0).ElementAt(0));

            Assert.IsTrue(result.ElementAt(0).Count == 1);
            Assert.IsTrue(result.ElementAt(1).Count == 0);
        }
    }
}
