using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MyCSharpLib.CSharp
{
    internal class ScratchPad
    {
        public string PracticeHere(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c.Equals('*'))
                {
                    if (stack.Count != 0)
                        stack.Pop();
                    continue;
                }

                stack.Push(c);
            }

            return string.Concat(stack.Reverse());
        }
    }
}
