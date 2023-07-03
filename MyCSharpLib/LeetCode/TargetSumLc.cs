using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class TargetSumLc
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            return Helper(nums, target, nums.Length, 0, 0);
        }

        private int Helper(int[] nums, int target, int n, int i, int curr)
        {
            if (curr == target && i == n)
                return 1;

            if (i >= n)
                return 0;

            var ans = 0;

            ans += Helper(nums, target, n, i+1, curr - nums[i]);
            ans += Helper(nums, target, n, i+1, curr + nums[i]);
            return ans;
        }
    }
}
