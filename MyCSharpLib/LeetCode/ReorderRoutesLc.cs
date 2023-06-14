using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class ReorderRoutesLc
    {
        private int result;
        private List<List<(int, bool)>> graph;
        private bool[] visited;

        public int MinReorder(int n, int[][] connections)
        {
            graph = new List<List<(int, bool)>>();
            visited = new bool[n];
            result = 0;

            foreach (var connection in connections)
            {
                var v1 = connection[0];
                var v2 = connection[1];

                if(graph.ElementAtOrDefault(v1)==null)
                        graph.Insert(v1, new List<(int, bool)>());
                if (graph.ElementAtOrDefault(v2) == null)
                    graph.Insert(v2, new List<(int, bool)>());

                graph[v1].Add((v2, true));
                graph[v2].Add((v1, false));
            }

            dfs(0, n);
            return result;
        }

        private void dfs(int start, int n)
        {
            visited[start] = true;
            for (var i = 0; i < n; i++)
            {
                if (visited[i])
                    continue;
                
                if (graph[start][i].Item2)
                    result++;
                
                dfs(i, n);
            }
        }
    }
}
