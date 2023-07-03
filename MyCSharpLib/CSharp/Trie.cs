using System.Collections.Generic;

namespace MyCSharpLib.CSharp
{
    public class TrieNode
    {
        public IDictionary<char, TrieNode> Children;
        public bool Ends;
        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
        }
    }

    public class Trie
    {
        private TrieNode root;
        public Trie()
        {
            root = new TrieNode();
        }

        public bool Search(string word)
        {
            var start = root;
            foreach (var ch in word)
            {
                if (start.Children.TryGetValue(ch, out var child))
                {
                    start = child;
                }
                else
                {
                    return false;
                }
            }
            return start.Ends;
        }

        public void Insert(string word)
        {
            var start = root;
            foreach (var ch in word)
            {
                if (!start.Children.ContainsKey(ch))
                    start.Children.Add(ch, new TrieNode());

                start = start.Children[ch];
            }
            start.Ends = true;
        }
    }
}
