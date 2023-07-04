using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class SpiralMatrixLc
    {
        public int[][] GenerateMatrix(int n)
        {
            var matrix = new int[n][];
            for (int k = 0; k < n; k++)
            {
                matrix[k] = new int[n];
            }

            int i = 0;
            int j = 0;

            //0: right, 1: down, 2: left, 3: up
            var dir = 0;

            for (int k = 1; k <= n * n; k++)
            {

                if (dir == 0)
                {
                    if (j < n && matrix[i][j] == 0)
                        matrix[i][j++] = k;
                    else
                    {
                        dir = 1;
                        i++;
                        j--;
                        k--;
                    }
                }
                else if (dir == 1)
                {
                    if (i < n && matrix[i][j] == 0)
                        matrix[i++][j] = k;
                    else
                    {
                        dir = 2;
                        i--;
                        j--;
                        k--;
                    }
                }
                else if (dir == 2)
                {
                    if (j >= 0 && matrix[i][j] == 0)
                        matrix[i][j--] = k;
                    else
                    {
                        dir = 3;
                        j++;
                        i--;
                        k--;
                    }
                }
                else
                {
                    if (i >= 0 && matrix[i][j] == 0)
                        matrix[i--][j] = k;
                    else
                    {
                        dir = 0;
                        i++;
                        j++;
                        k--;
                    }
                }
            }
            return matrix;
        }
    }
}
