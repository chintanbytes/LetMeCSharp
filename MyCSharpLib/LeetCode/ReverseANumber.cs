namespace MyCSharpLib.LeetCode;

public class ReverseANumber
{
    public int Reverse(int x)
    {
        long result = 0;
        
        while (x !=0 )
        {
            var lastDigit = x % 10;
            x = x / 10;
            result = result * 10 + lastDigit;
        }

        return result switch
        {
            int.MinValue or > int.MaxValue => 0,
            _ => (int)result
        };
    }
}