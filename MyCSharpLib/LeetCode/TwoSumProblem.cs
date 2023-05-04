using System.Collections.Generic;

namespace MyCSharpLib.LeetCode
{
    public class TwoSumProblem
    {
        public int[] TowSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dic.Count == 0)
                {
                    dic.Add(nums[i], i);
                    continue;
                }

                var diff = target - nums[i];
                if (dic.ContainsKey(diff))
                {
                    return new[] { dic[diff], i };
                }
                else
                {
                    if (!dic.ContainsKey(nums[i]))
                        dic.Add(nums[i], i);
                }
            }
            return new[] { -1, -1 };

        }
    }
}