using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode
{
    public class ValidParenthesesProblem
    {
        public bool IsStringValid(string st)
        {
            Stack<char> chars = new();
            if (string.IsNullOrEmpty(st))
                return true;

            if(st.Length%2 != 0)
                return false;

            foreach (var ch in st)
            {
                if (ch is '(' or '{' or '[')
                {
                    chars.Push(ch);
                }
                else if (ch is ')')
                {
                    if(chars.Count == 0 || chars.Peek() != '(') 
                        return false;
                    chars.Pop();
                }
                else if (ch is '}')
                {
                    if (chars.Count == 0 || chars.Peek() != '{') 
                        return false;
                    chars.Pop();
                }
                else if (ch is ']')
                {
                    if (chars.Count == 0 || chars.Peek() != '[') 
                        return false;
                    chars.Pop();
                }
                else
                {
                    return false;
                }
            }

            return chars.Count == 0;
        }

    }
}
