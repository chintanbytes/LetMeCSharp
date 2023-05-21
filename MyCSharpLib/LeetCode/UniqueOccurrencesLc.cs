namespace MyCSharpLib.LeetCode
{
    public class UniqueOccurrencesLc
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var map = new int[2001];
            var check = new bool[1000];

            foreach (var n in arr)
            {
                map[n + 1000]++;
            }

            foreach (var n in map)
            {
                if (n != 0 && check[n-1] == false)
                    check[n-1] = true;
                else if (n == 0)
                    continue;
                else
                    return false;
            }

            return true;
        }
    }
}
