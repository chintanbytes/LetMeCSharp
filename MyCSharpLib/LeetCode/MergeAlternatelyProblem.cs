using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class MergeAlternatelyProblem
    {
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder result = new();

            var minLength = Math.Max(word1.Length, word2.Length);
            for (var i = 0; i < minLength; i++)
            {
                if (i < word1.Length)
                {
                    result.Append(word1[i]);
                }
                if (i < word2.Length)
                {
                    result.Append(word2[i]);
                }
            }

            return result.ToString();
        }
    }
}
