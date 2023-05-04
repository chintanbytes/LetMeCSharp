namespace MyCSharpLib.LeetCode
{
    public class IsNumberPalindromeProblem
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            var copy = x;
            var newNum = 0;
            while (copy > 0)
            {
                var lastDigit = copy % 10;
                copy = copy / 10;
                newNum = newNum * 10 + lastDigit;
                // newNum     = 0*10 +1 = 1
                // newNum     = 1*10 +2 = 12
                // newNum     = 12*10+1 = 121
            }
            return newNum == x;
        }
    }
}
