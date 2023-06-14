using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyCSharpLib.LeetCode
{
    public class EvaluateDivisionLc
    {
        private Dictionary<string, Dictionary<string, double>> map;
        double[] result;
        private bool found;
        private IList<string> visited;
        private string current;

        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            map = new Dictionary<string, Dictionary<string, double>>();
            result = new double[queries.Count];
            visited = new List<string>();

            for (int i = 0; i < equations.Count; i++)
            {
                var str1 = equations[i][0];
                var str2 = equations[i][1];
                var value = values[i];

                if (!map.ContainsKey(str1))
                {
                    map.Add(str1, new Dictionary<string, double>());
                }
                map[str1].Add(str2, value);

                if (!map.ContainsKey(str2))
                {
                    map.Add(str2, new Dictionary<string, double>());
                }
                map[str2].Add(str1, 1 / value);
            }

            for (var i = 0; i < queries.Count; i++)
            {
                visited.Clear();
                var start = current = queries[i][0];
                var end = queries[i][1];

                if (map.ContainsKey(start) && map.ContainsKey(end))
                {
                    if (start == end) //if both are same, 1
                    {
                        result[i] = 1;
                    }
                    else
                    {
                        var ans = Dfs(current, queries[i][1]);
                        
                        if (found) //Equation resolves
                        {
                            result[i] = ans;
                            found = false;
                        }
                        else //If nodes exist but no path
                        {
                            result[i] = -1;
                        }
                    }
                }
                else //if not in map, -1
                {
                    result[i] = -1.0;  
                }
            }
            return result;
        }

        private double Dfs(string start, string end)
        {
            visited.Add(start);
            var answer = 1.0;
            
            foreach (var (str, value) in map[start])
            {
                if (visited.Contains(str))
                {
                    continue;
                }

                if (str == end)
                {
                    found = true;
                    return value;
                }

                answer = value * Dfs(str, end);
            }
           
            return answer;
        }
    }
}
