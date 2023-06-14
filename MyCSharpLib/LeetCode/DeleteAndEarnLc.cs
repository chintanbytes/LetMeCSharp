using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class DeleteAndEarnLc
    {

        public int DeleteAndEarn(int[] nums)
        {
            var freq = new int[nums.Max() + 1];
            foreach (var num in nums)
                freq[num]++;

            int n = freq.Length;

            if (n == 1)
                return freq[0];
            if (n == 2)
                return Math.Max(freq[0], freq[1]);

            var dp = new int[nums.Max() + 1];

            dp[0] = freq[0];
            dp[1] = Math.Max(freq[0], freq[1]);
            dp[2] = Math.Max(dp[1], (2 * freq[2]) + dp[0]);

            for (int i = 3; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + (i * freq[i]));
            }

            return dp[n - 1];
        }

        public int DeleteAndEarnTopDown(int[] nums)
        {
            var n = nums.Length;

            if (n == 1)
                return nums[0];
            if (n == 2)
                return Math.Max(nums[0], nums[1]);

            var max = int.MinValue;

            var dict = new int[nums.Max()+1];
            var dp = Enumerable.Repeat(-1, nums.Max() + 1).ToArray();

            foreach (var num in nums)
                dict[num]++;

            for (int i = 0; i < dict.Length; i++)
            {
                if (dict[i] > 0)
                {
                    var tempMax = GetPoints(dict, i, dp);
                    max = tempMax > max ? tempMax : max;
                }
            }

            int GetPoints(int[] dict, int index, int[] dp)
            {
                var originalIndex = index;
                if (dp[index] != -1)
                    return dp[index];

                var copyDict = dict.ToArray();
                var points = index * copyDict[index];

                copyDict[index] = 0;

                if (index + 1 < copyDict.Length)
                    copyDict[index + 1] = 0;

                var pointsForLeftOver = 0;

                while (index < copyDict.Length && copyDict[index] == 0)
                {
                    index++;
                }

                if (index < copyDict.Length)
                    pointsForLeftOver = Math.Max(pointsForLeftOver, GetPoints(copyDict, index, dp));

                if (index + 1 < copyDict.Length)
                    pointsForLeftOver = Math.Max(pointsForLeftOver, GetPoints(copyDict, index + 1, dp));

                points += pointsForLeftOver;
                dp[originalIndex] = points;
                return points;
            }

            return max;
        }
    }
}
