using System;
using System.Collections.Generic;
using System.Text;

namespace MyCSharpLib.LeetCode
{
    public class ReverseWordsProblem
    {
        public string ReserveWords(string s)
        {
            Stack<string> words = new();
            using (var it = s.GetEnumerator())
            {
                while(it.MoveNext())
                {
                    if (it.Current == ' ')
                        continue;
                    var word = string.Empty;

                    var keepGoing= true;
                    while (keepGoing && it.Current != ' ')
                    {
                        word += it.Current;
                        keepGoing = it.MoveNext();
                    }
                    words.Push(word);
                    words.Push(" ");
                }
            }

            //remove last space
            words.Pop();

            //rebuild the string
            StringBuilder builder = new();
            while(words.Count > 0)
            {   
                builder.Append(words.Pop());
            }


            /*var words = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var builder = new StringBuilder();
            for (var i = words.Length-1; i >= 0; i--)
            {
                builder.Append(words[i].Trim());

                if (i>0)
                {
                    builder.Append(' ');
                }
            }*/

            return builder.ToString();
        }
    }
}