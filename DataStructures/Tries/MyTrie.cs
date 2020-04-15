using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Tries
{
    public class MyTrie
    {
        private Node _root;

        public MyTrie()
        {
            _root = new Node((char) 0);
        }

        public void Insert(string word)
        {
            var characters = word.ToCharArray();

            var current = _root;
            for (var i = 0; i < characters.Length; i++)
            {
                var value = characters[i];
                if (current.Contains(value))
                {
                    current = current.GetNode(value);
                    continue;
                }
                else
                {
                    current.AddChild(value, isEndOfWorld : i == (characters.Length - 1));
                    current = current.GetNode(value);
                }
            }
        }

        public bool HasWord(string word)
        {
            var current = _root;
            var characters = word.ToCharArray();
            for (var i = 0; i < characters.Length; i++)
            {
                var value = characters[i];

                if (!current.Contains(value))
                    return false;

                if (i == (characters.Length - 1))
                {
                    var node = current.GetNode(value);
                    return node.IsEndOfWorld;
                }

                current = current.GetNode(value);
            }

            return false;
        }

        private class Node
        {
            private Dictionary<char, Node> _children;

            public Node(char value, bool isEndOfWorld = false)
            {
                Value = value;
                IsEndOfWorld = isEndOfWorld;
                _children = new Dictionary<char, Node>();
            }

            public char Value { get; }
            public bool IsEndOfWorld { get; }

            public void AddChild(char value, bool isEndOfWorld)
            {
                var node = new Node(value, isEndOfWorld);
                _children.Add(value, node);
            }

            public Node GetNode(char value)
            {
                Node node = null;
                _children.TryGetValue(value, out node);

                return node;
            }

            public bool Contains(char value)
            {
                return _children.ContainsKey(value);
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }
    }
}
