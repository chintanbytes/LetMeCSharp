using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class HouseRobberLc
    {
        public int Rob(int[] nums)
        {
            var n = nums.Length;

            var maxPoints = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var temp = GetPoints(i, nums, n);
                maxPoints = Math.Max(temp, maxPoints);
            }

            return maxPoints;
        }

        private int GetPoints(int index, int[] nums, int n)
        {
            var numsCopy = nums.ToArray();
            var points = 0;

            points = numsCopy[index];
            numsCopy[index] = -1;

            if (index - 1 >= 0)
            {
                numsCopy[index - 1] = -1;
            }

            if (index + 1 < n)
            {
                numsCopy[index + 1] = -1;
            }

            var extra = 0;

            for (int i = 0; i < n; i++)
            {
                if (numsCopy[i] != -1)
                {
                    var temp = GetPoints(i, numsCopy, n);
                    extra = Math.Max(temp, extra);
                }
            }

            points += extra;
            return points;

        }
    }
}
