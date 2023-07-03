using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class NumTilingsLc
    {
        public int NumTilings(int n)
        {
            var dp = new int[n + 1, 4];
            dp[0, 3] = 1;
            for (int i = 1; i < n + 1; i++)
            {
                dp[i, 0] += dp[i - 1, 3];

                dp[i, 1] += dp[i - 1, 0];
                dp[i, 1] += dp[i - 1, 2];

                dp[i, 2] += dp[i - 1, 0];
                dp[i, 2] += dp[i - 1, 1];

                dp[i, 3] += dp[i - 1, 3];
                dp[i, 3] += dp[i - 1, 1];
                dp[i, 3] += dp[i - 1, 2];
            }

            return (int)dp[n, 3];// % 100_00_00_007;
        }
    }
}
