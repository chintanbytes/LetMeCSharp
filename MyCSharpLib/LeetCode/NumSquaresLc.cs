using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class NumSquaresLc
    {
        public int NumSquares(int n)
        {
            var items = new List<int>();
            int m = 1;
            while (m * m <= n)
            {
                items.Add(m * m);
                m++;
            }

            int[,] dp = new int[m, n + 1];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if(j == 0)
                        dp[i, j] = 0;
                    else if(i==0)
                        dp[i,j] = int.MaxValue;
                    else if (items[i - 1] > j)
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        var inc = 1 + dp[i, j - items[i - 1]];
                        var exc = dp[i - 1, j];
                        dp[i, j] = Math.Min(inc, exc);
                    }
                }
            }

            return dp[m-1, n];

            //return lps(items, n, items.Count);
        }

        private int lps(IList<int> nums, int n, int ct)
        {
            if (n == 0)
                return 0;

            if (ct == 0)
                return int.MaxValue;
            var ans = 0;
            if (nums[ct - 1] > n)
                ans += lps(nums, n, ct - 1);
            else
            {
                var inc = 1 + lps(nums, n - nums[ct - 1], ct);
                var exc = lps(nums, n, ct - 1);
                ans += Math.Min(inc, exc);
            }
            return ans;
        }
    }
}
