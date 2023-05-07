namespace MyCSharpLib.LeetCode
{
    public class RemoveDuplicates
    {
        public int Remove(int[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            var ans = 1;
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1])
                {
                    numbers[ans++] = numbers[i];
                    
                }
            }
            return ans;
        }
    }
}