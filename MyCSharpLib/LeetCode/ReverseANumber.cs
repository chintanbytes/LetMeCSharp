using System;

namespace MyCSharpLib.LeetCode;

public class ReverseANumber
{
    public int Reverse(int x)
    {
        int result = 0;
        
        while (x !=0 )
        {
            var lastDigit = x % 10;
            x = x / 10;
            if (result > int.MaxValue/10 || result == int.MaxValue/10 && lastDigit >= int.MaxValue % 10)
            {
                return 0;
            }

            if (result < int.MinValue / 10 || result == int.MinValue / 10 && lastDigit <= int.MinValue % 10)
            {
                return 0;
            }

            result = result * 10 + lastDigit;
        }

       return result;
    }
}