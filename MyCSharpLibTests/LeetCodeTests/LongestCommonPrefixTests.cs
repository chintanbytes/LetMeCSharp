using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class LongestCommonPrefixTests
    {
        private LongestCommonPrefixProblem _problem;

        [TestInitialize]
        public void setup()
        {
            _problem = new LongestCommonPrefixProblem();
        }

        [TestMethod]
        public void LongestCommonPrefixTest()
        {
            var prefix = _problem.LongestCommonPrefix(new List<string>() { "flower", "flow", "flight" });
            Assert.AreEqual("fl", prefix);

            prefix = _problem.LongestCommonPrefix(new List<string>() { "dog", "racecar", "car" });
            Assert.AreEqual("", prefix);
        }

        [TestMethod]
        public void LongestCommonPrefixDumbTest()
        {
            var prefix = _problem.LongestCommonPrefixDumb(new List<string>() { "flower", "flow", "flight" });
            Assert.AreEqual("fl", prefix);

            prefix = _problem.LongestCommonPrefixDumb(new List<string>() { "dog", "racecar", "car" });
            Assert.AreEqual("", prefix);
            
        }

    }
}
