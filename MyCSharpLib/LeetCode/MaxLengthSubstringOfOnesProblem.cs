using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class MaxLengthSubstringOfOnesProblem
    {
        public int MaxLengthSubstringOfOnes(int[] nums, int k)
        {
            //only 1 element
            if (nums.Length == 1)
            {
                return (nums[0] == 1 || k == 1) ? 1 : 0;
            }

            if (nums.Length == k)
            {
                return k;
            }

            var count = 0;
            var flipped = 0;
            var start = 0;
            var max = 0;

            foreach (var num in nums)
            {
                if (num == 1 || flipped < k)
                {
                    count++;
                    if (num == 0)
                    {
                        flipped++;
                    }

                    max = max > count ? max : count;
                }
                else
                {
                    max = max > count ? max : count;
                    while (nums[start] == 1)
                    {
                        start++;
                        count--;
                    }

                    start++;
                }
            }
            return max;
        }
    }
}
