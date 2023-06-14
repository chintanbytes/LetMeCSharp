using System.Collections.Generic;
using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class EvaluateDivisionTests
    {

        [TestMethod]
        public void EvaluateTest1()
        {
            var sol = new EvaluateDivisionLc();
            var values = new double[] { 2.0, 3.0 };
            IList<IList<string>> equations = new List<IList<string>>()
                { new List<string>() { "a", "b" }, new List<string>() { "b", "c" }};
            IList<IList<string>> queries = new List<IList<string>>()
                { new List<string>() { "a", "c" }, new List < string >() { "b", "a" }, new List < string >() { "a", "e" }, new List < string >() { "a", "a" }, new List < string >() { "x", "x" } };
            var result = sol.CalcEquation(equations, values, queries);
        }

        [TestMethod]
        public void EvaluateTest2()
        {
            var sol = new EvaluateDivisionLc();
            var values = new double[] { 1.5, 2.5, 5.0 };
            IList<IList<string>> equations = new List<IList<string>>()
                { new List<string>() { "a","b" }, new List<string>() { "b","c" }, new List<string>() { "bc","cd" }};
            IList<IList<string>> queries = new List<IList<string>>()
                { new List<string>() { "a","c" }, new List < string >() { "c","b" }, new List < string >() { "bc","cd" }, new List < string >() { "cd","bc" }};
            var result = sol.CalcEquation(equations, values, queries);
        }

        [TestMethod]
        public void EvaluateTest3()
        {
            var sol = new EvaluateDivisionLc();
            var values = new double[] { 0.5 };
            IList<IList<string>> equations = new List<IList<string>>()
                { new List<string>() { "a", "b" }};
            IList<IList<string>> queries = new List<IList<string>>()
                { new List<string>() { "a", "b" }, new List < string >() { "b", "a" }, new List < string >() { "a", "c" }, new List < string >() { "x", "y" }};
            var result = sol.CalcEquation(equations, values, queries);
        }

        [TestMethod]
        public void EvaluateTest4()
        {
            var sol = new EvaluateDivisionLc();
            var values = new double[] { 3.0, 4.0, 5.0, 6.0 };
            IList<IList<string>> equations = new List<IList<string>>()
                { new List<string>() { "x1","x2" },new List<string>() { "x2","x3" }, new List<string>() { "x3","x4" }, new List<string>() { "x4","x5" }};
            IList<IList<string>> queries = new List<IList<string>>()
                { new List<string>() { "x1", "x5" }};
            var result = sol.CalcEquation(equations, values, queries);
        }
    }
}