using System;
using System.Collections.Generic;

namespace MyCSharpLib.LeetCode
{
    public class RomanToIntProblem
    {
        public int RomanToInt(string roman)
        {
            var intNumber = 0;
            var last = char.MinValue;

            foreach (var c in roman)
            {
                switch (c)
                {
                    case 'I':
                        intNumber++;
                        break;
                    case 'V':
                        if (last == 'I')
                            intNumber += 3;
                        else
                            intNumber += 5;
                        break;
                    case 'X':
                        if (last == 'I')
                            intNumber += 8;
                        else
                            intNumber += 10;
                        break;
                    case 'L':
                        if (last == 'X')
                            intNumber += 30;
                        else
                            intNumber += 50;
                        break;
                    case 'C':
                        if (last == 'X')
                            intNumber += 80;
                        else
                            intNumber += 100;
                        break;
                    case 'D':
                        if (last == 'C')
                            intNumber += 300;
                        else
                            intNumber += 500;
                        break;
                    case 'M':
                        if (last == 'C')
                            intNumber += 800;
                        else
                            intNumber += 1000;
                        break;
                    default:
                        throw new ArgumentException("Not a valid roman number");
                }

                last = c;
            }

            return intNumber;
        }


        public int RomanToIntUsingDictionary(string roman)
        {
            Dictionary<char, int> romanMap = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            var ans = 0;
            var previousCh = char.MinValue;
            foreach (var ch in roman)
            {
                if (romanMap.TryGetValue(ch, out var val))
                {
                    if (previousCh != char.MinValue && romanMap[previousCh] < val)
                    {
                        ans = ans - 2 * (romanMap[previousCh]) + val;
                    }
                    else
                    {
                        ans += val;
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid roman number");
                }

                previousCh = ch;
            }

            return ans;
        }
    }
}
