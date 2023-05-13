using System.Collections.Generic;
using System.Linq;

namespace MyCSharpLib.LeetCode
{
    public class KidsWithCandies
    {
        public IList<bool> KidsWithCandiesSol(int[] candies, int extraCandies)
        {
            var n = candies.Length;
            IList<bool> result = new List<bool>(new bool[n]);
            var max = candies.Max();

            for (int i = 0; i < n; i++)
            {
                if (candies[i] + extraCandies > max)
                {
                    result[i] = true;
                }
            }


            candies.Select(x => x + extraCandies > candies.Max()).ToArray();

            return result;
        }
    }
}