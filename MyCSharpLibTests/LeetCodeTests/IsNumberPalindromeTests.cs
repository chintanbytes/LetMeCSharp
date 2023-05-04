using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class IsNumberPalindromeTests
    {

        private IsNumberPalindromeProblem palindrome;

        [TestInitialize]
        public void setup()
        {
            palindrome = new();
        }

        [TestMethod]
        public void TestIfNumberIsPalindrome()
        {
            Assert.IsTrue(palindrome.IsPalindrome(121));
            Assert.IsTrue(palindrome.IsPalindrome(1221));
            Assert.IsTrue(palindrome.IsPalindrome(12121));
            Assert.IsTrue(palindrome.IsPalindrome(0));
            Assert.IsTrue(palindrome.IsPalindrome(1));
            Assert.IsTrue(palindrome.IsPalindrome(123454321));
            Assert.IsFalse(palindrome.IsPalindrome(12345));
        }
    }
}
