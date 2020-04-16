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

                current.AddChild(value, isEndOfWorld : i == (characters.Length - 1));
                current = current.GetNode(value);
            }
        }

        public bool HasWord(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            var current = _root;
            foreach (var value in word)
            {
                if (!current.Contains(value))
                    return false;

                current = current.GetNode(value);
            }

            return current.IsEndOfWorld;
        }

        public char[] GetAll()
        {
            var list = new List<char>();
            InOrderTraverse(_root, list);

            return list.ToArray();
        }

        public void Remove(string word)
        {
            var current = _root;
            for (var i = 0; i < word.Length; i++)
            {
                var node = current.GetNode(word[i]);
                if (node == null) return;

                if (node.IsEndOfWorld)
                {
                    if (i == (word.Length - 1))
                        node.IsEndOfWorld = false;
                    else
                        continue;
                }

                if (node.HasChildren())
                {
                    current = node;
                    continue;
                }
                else
                {
                    current.RemoveChild(node.Value);
                }
            }
        }

        #region Privates

        private void InOrderTraverse(Node node, List<char> letters)
        {
            letters.Add(node.Value);

            foreach (var child in node.GetChildren())
                InOrderTraverse(child, letters);
        }

        private void PostOrderTraverse(Node node, List<char> letters)
        {
            foreach (var child in node.GetChildren())
                InOrderTraverse(child, letters);

            letters.Add(node.Value);
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
            public bool IsEndOfWorld { get; set; }

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

            public Node[] GetChildren()
            {
                return _children.Values.ToArray();
            }

            public bool Contains(char value)
            {
                return _children.ContainsKey(value);
            }

            public bool HasChildren()
            {
                return _children.Any();
            }

            public void RemoveChild(char ch)
            {
                _children.Remove(ch);
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }

        #endregion
    }
}
