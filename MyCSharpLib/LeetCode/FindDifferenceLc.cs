using System.Collections.Generic;
using System.Linq;

namespace MyCSharpLib.LeetCode
{
    public class FindDifferenceLc
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var arr1 = new bool[2001];
            var arr2 = new bool[2001];
            var dups = new bool[2001];

            foreach (var n in nums1)
            {
                arr1[n + 1000] = true;
                dups[n + 1000] = true;
            }

            foreach (var n in nums2)
            {
                if (dups[n + 1000])
                {
                    arr1[n + 1000] = false;
                    continue;
                }
                arr2[n + 1000] = true;
            }

            IList<IList<int>> result = new List<IList<int>>();
            result.Insert(0, new List<int>());
            result.Insert(1, new List<int>());

            for (var i = 0; i < 2001; i++)
            {
                if (arr1[i] == true)
                {
                    result.ElementAt(0).Add(i - 1000);
                }
                if (arr2[i] == true)
                {
                    result.ElementAt(1).Add(i - 1000);
                }
            }

            return result;

        }
    }
}
