using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class SmallestInfiniteSetLc
    {
        private List<int> set;
        private int count;

        public SmallestInfiniteSetLc()
        {
            set = new();
            for (int i = 0; i < 1000; i++)
            {
                AddBack(i + 1);
            }
        }

        public int PopSmallest()
        {
            if (set.Count == 0)
                return 0;

            int min = set[0];
            var maxIndex = set.Count - 1;

            set[0] = set[maxIndex];
            set.RemoveAt(maxIndex);
            count--;
            var i = 0;
            while (true)
            {
                var lci = 2 * i + 1;
                var rci = 2 * i + 2;
                var minIndex = i;

                if (lci< count && set[lci] < set[minIndex])
                    minIndex = lci;

                if (rci < count && set[rci] < set[minIndex])
                    minIndex = rci;

                if (i == minIndex)
                    break;

                (set[minIndex], set[i]) = (set[i], set[minIndex]);

                i = minIndex;
            }
            return min;
        }

        public void AddBack(int num)
        {
            if (set.Count == 1000)
                return;

            //Add at the end
            set.Add(num);
            var ci = set.Count - 1;

            //Heapify Up for the min heap
            while (ci > 0)
            {

                var pi = (ci - 1) / 2;
                if (set[pi] > set[ci])
                {
                    //Swap parent and child
                    (set[pi], set[ci]) = (set[ci], set[pi]);

                    //Make child index as parent index
                    ci = pi;

                }
                else
                {
                    break;
                }
            }

            count++;
        }
    }
}
