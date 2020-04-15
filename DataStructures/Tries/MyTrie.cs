using System;

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
                    current = current.AddChild(value);
                    current.IsEndOfWorld = i == (characters.Length - 1);
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

                if (current.NotContains(value))
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
            private static int ALPHABET_SIZE = 26;
            public Node(char value)
            {
                Value = value;
                IsEndOfWorld = false;
                Children = new Node[ALPHABET_SIZE];
            }

            public char Value { get; }
            public Node[] Children { get; }
            public bool IsEndOfWorld { get; set; }

            public Node AddChild(char value)
            {
                var index = GetIndex(value);
                Children[index] = new Node(value);

                return Children[index];
            }

            public bool Contains(char value)
            {
                return GetNode(value) != null;
            }

            public bool NotContains(char value)
            {
                return Contains(value) == false;
            }
            public Node GetNode(char value)
            {
                return Children[GetIndex(value)];
            }

            private int GetIndex(char value)
            {
                return value - 'a';
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }
    }
}
