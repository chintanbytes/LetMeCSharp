using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class MaxAreaLc
    {
        public int MaxArea(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var ans = 0;

            while (right > left)
            {

                var temp = (right - left) * Math.Min(height[left], height[right]);

                if (height[left] <= height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }

                ans = ans > temp ? ans : temp;

            }

            return ans;

        }
    }
}
