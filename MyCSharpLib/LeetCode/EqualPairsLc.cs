using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class EqualPairsLc
    {
        public int EqualPairs(int[][] grid)
        {
            int n = grid.Length;
            var xMap = new Dictionary<int, int>();
            int x = 0;
            int y = 0;

            while (y < n)
            {
                x = 0;
                var hash = 0;
                while (x < n)
                {
                    hash = HashCode.Combine(hash, grid[y][x].GetHashCode());
                    x++;
                }

                xMap.TryGetValue(hash, out var freq);
                xMap[hash] = freq+1;

                y++;
            }

            x = 0;
            y = 0;
            int count = 0;

            while (x < n)
            {
                y = 0;
                var hash = 0;
                while (y < n)
                {
                    hash = HashCode.Combine(hash, grid[y][x].GetHashCode());
                    y++;
                }

                if (xMap.ContainsKey(hash))
                {
                    count += xMap[hash];
                }

                x++;
            }

            return count;
        }
    }
}
