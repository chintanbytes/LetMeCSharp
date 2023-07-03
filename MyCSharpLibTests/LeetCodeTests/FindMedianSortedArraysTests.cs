using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests;

[TestClass]
public class FindMedianSortedArraysTests
{
    [TestMethod]
    public void FindMedianSortedArraysTest1()
    {
        var sol = new FindMedianSortedArraysLc();
        var ans = sol.FindMedianSortedArraysBS(new[] { 1,3 }, new[] {2});
        Assert.AreEqual(2,ans);
    }

    [TestMethod]
    public void FindMedianSortedArraysTest2()
    {
        var sol = new FindMedianSortedArraysLc();
        var ans = sol.FindMedianSortedArraysBS(new[] { 1, 2 }, new[] { 3, 4 });
        Assert.AreEqual(2.5, ans);
    }

    [TestMethod]
    public void FindMedianSortedArraysTest3()
    {
        var sol = new FindMedianSortedArraysLc();
        var ans = sol.FindMedianSortedArraysBS(new []{2}, new int[]{});
        Assert.AreEqual(2, ans);
    }
}

