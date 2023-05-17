using System.Diagnostics;

namespace MyCSharpLib.LeetCode
{
    public class FindMaxAverageProblem
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            if (nums.Length == 1)
                return nums[0];

            var maxSum = 0;
            var lastSum = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (i < k)
                {
                    lastSum += nums[i];
                    maxSum = lastSum;
                    continue;
                }

                lastSum -= nums[i - k];
                lastSum += nums[i];

                maxSum = maxSum > lastSum ? maxSum : lastSum;

            }

            return (double)maxSum / k;
        }

        private bool isVowel(char ch)
        {
            return ch is 'a' or 'e' or 'i' or 'o' or 'u';
        }
    }
}