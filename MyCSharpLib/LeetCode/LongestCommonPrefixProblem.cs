using System.Collections.Generic;
using System.Linq;

namespace MyCSharpLib.LeetCode
{
    public class LongestCommonPrefixProblem
    {
        public string LongestCommonPrefix(List<string> strings)
        {
            strings.Sort();
            var first = strings.First();
            var last = strings.Last();

            var index = 0;

            for (var i = 0; i < first.Length; i++)
            {
                if (first[i] == last[i])
                {
                    index++;
                    continue;
                }
                break;
            }

            return first[..index];
        }

        public string LongestCommonPrefixDumb(List<string> strings)
        {
            var shortestLength = strings.Select(s => s.Length).Prepend(int.MaxValue).Min();
            var result = string.Empty;
            
            for (var i = 0; i < shortestLength; i++)
            {
                var ch = char.MinValue;

                foreach (var s in strings)
                {
                    if (ch.Equals(char.MinValue))
                        ch = s.ElementAt(i);

                    else if (!ch.Equals(s.ElementAt(i)))
                    {
                        ch = char.MinValue;
                        break;
                    }
                }

                if (ch.Equals(char.MinValue))
                    return result;
                result += ch;
            }

            return result;
        }
    }
}
