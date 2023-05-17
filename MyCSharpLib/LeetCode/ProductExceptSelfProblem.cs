namespace MyCSharpLib.LeetCode
{
    public class ProductExceptSelfProblem
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            var prod = 1;
            int i;

            for (i = 0; i < nums.Length; i++)
            {
                result[i] = prod;
                prod *= nums[i];
            }

            prod = 1;

            for (i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = result[i] * prod;
                prod = prod * nums[i];
            }

            return result;
        }
    }
}