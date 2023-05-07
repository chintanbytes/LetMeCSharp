using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class ValidParenthesesTests
    {
        [TestMethod]
        public void TestValidParanthesis1()
        {
            ValidParenthesesProblem problem = new();
            Assert.IsTrue(problem.IsStringValid("()"));
        }

        [TestMethod]
        public void TestValidParanthesis2()
        {
            ValidParenthesesProblem problem = new();
            Assert.IsFalse(problem.IsStringValid("(("));
        }

        [TestMethod]
        public void TestValidParanthesis3()
        {
            ValidParenthesesProblem problem = new();
            Assert.IsTrue(problem.IsStringValid("({[]})"));
        }


        [TestMethod]
        public void TestValidParanthesis4()
        {
            ValidParenthesesProblem problem = new();
            Assert.IsTrue(problem.IsStringValid("(){}[]{}{}"));
        }

        [TestMethod]
        public void TestValidParanthesis5()
        {
            ValidParenthesesProblem problem = new();
            Assert.IsFalse(problem.IsStringValid("){}[]{}{}"));
        }
    }
}
