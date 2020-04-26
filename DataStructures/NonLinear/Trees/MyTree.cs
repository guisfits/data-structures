using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Trees
{
    public class MyTree : IEquatable<MyTree>
    {
        private Node _root;

        #region Insert

        public void Insert(IEnumerable<int> values)
        {
            foreach (var value in values)
                Insert(value);
        }

        public void Insert(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
            }
            else
            {
                var current = _root;
                while (current != null)
                {
                    current = current.AssignOrGetNext(value);
                }
            }
        }

        #endregion

        #region Contains

        public bool Contains(int value)
        {
            var current = _root;
            while (current != null)
            {
                if (current.Value == value)
                    return true;

                current = current.Next(value);
            }

            return false;
        }

        #endregion

        #region GetAll

        public int[] GetAll(TraversingMethod method)
        {
            var list = new List<int>();
            switch (method)
            {
                case TraversingMethod.PreOrder:
                    TraversePreOrder(_root, list);
                    break;

                case TraversingMethod.InOrder:
                    TraverseInOrder(_root, list);
                    break;

                case TraversingMethod.PostOrder:
                    TraversePostOrder(_root, list);
                    break;

                case TraversingMethod.LevelOrder:
                    TraverseOrderLevel(list);
                    break;

                default:
                    break;
            }

            return list.ToArray();
        }

        public enum TraversingMethod { PreOrder, InOrder, PostOrder, LevelOrder }

        private void TraversePreOrder(Node root, List<int> list)
        {
            if (root == null) return;
            list.Add(root.Value);
            TraversePreOrder(root.Left, list);
            TraversePreOrder(root.Right, list);
        }

        private void TraverseInOrder(Node root, List<int> list)
        {
            if (root == null) return;
            TraverseInOrder(root.Left, list);
            list.Add(root.Value);
            TraverseInOrder(root.Right, list);
        }

        private void TraversePostOrder(Node root, List<int> list)
        {
            if (root == null) return;
            TraversePostOrder(root.Left, list);
            TraversePostOrder(root.Right, list);
            list.Add(root.Value);
        }

        private void TraverseOrderLevel(List<int> list)
        {
            for (int i = 0; i <= this.GetHeight(); i++)
                list.AddRange(GetValuesAtDistance(i));
        }

        #endregion

        #region GetHeight

        public int GetHeight()
        {
            return Height(_root);
        }

        private int Height(Node root)
        {
            if (root == null)
                return -1;

            if (root.IsLeaf())
                return 0;

            return 1 + Math.Max(Height(root.Left), Height(root.Right));
        }

        #endregion

        #region GetMinValue

        public int GetMinValue()
        {
            if (_root == null)
                throw new InvalidOperationException();

            var current = _root;
            int min = _root.Value;;
            while (current != null)
            {
                min = current.Value;
                current = current.Left;
            }

            return min;
        }

        #endregion

        #region GetMaxValue

        public int GetMaxValue()
        {
            var current = _root;
            int value = _root.Value;
            while (current != null)
            {
                value = current.Value;
                current = current.Right;
            }

            return value;
        }

        #endregion

        #region Equals

        public bool Equals(MyTree other)
        {
            if (other == null) return false;
            return EqualsCore(this._root, other._root);
        }

        private bool EqualsCore(Node nodeA, Node nodeB)
        {
            if (nodeA == null && nodeB == null)
                return true;

            if (nodeA != null && nodeB != null)
                return nodeA.Value == nodeB.Value &&
                    EqualsCore(nodeA.Left, nodeB.Left) &&
                    EqualsCore(nodeA.Right, nodeB.Right);

            return false;
        }

        #endregion

        #region IsBinarySearchTree

        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(_root, int.MinValue, int.MaxValue);
        }

        private bool IsBinarySearchTree(Node node, int min, int max)
        {
            if (node == null)
                return true;

            if (node.IsBetween(min, max) == false)
                return false;

            return IsBinarySearchTree(node.Left, min, node.Value) && IsBinarySearchTree(node.Right, node.Value, max);
        }

        #endregion

        #region GetValuesAtDistance

        public IEnumerable<int> GetValuesAtDistance(int distance)
        {
            var list = new List<int>();
            GetRootNodeFromDistance(_root, distance, list);

            return list;
        }

        private void GetRootNodeFromDistance(Node node, int distance, List<int> list)
        {
            if (node == null) return;

            if (distance == 0)
            {
                list.Add(node.Value);
                return;
            }

            GetRootNodeFromDistance(node.Left, distance - 1, list);
            GetRootNodeFromDistance(node.Right, distance - 1, list);
        }

        #endregion

        #region Count

        public int Count()
        {
            return this.GetAll(TraversingMethod.LevelOrder).Count();
        }

        #endregion

        #region AreSibling

        public bool AreSibling(int valueA, int valueB)
        {
            return AreSibling(_root, valueA, valueB);
        }

        private bool AreSibling(Node node, int valueA, int valueB)
        {
            if (node == null)
                return false;

            if (node.Left == null || node.Right == null)
                return false;

            if ((node.Left.Value == valueA && node.Right.Value == valueB) || (node.Left.Value == valueB && node.Right.Value == valueA))
                return true;

            return AreSibling(_root.Left, valueA, valueB) || AreSibling(_root.Right, valueA, valueB);
        }

        #endregion

        #region GetAncestors

        public int? GetAncestor(int value)
        {
            var node = GetAncestorNode(_root, value);
            return node != null ? (int?) node.Value : null;
        }

        private Node GetAncestorNode(Node node, int value)
        {
            if (node == null)
                return null;

            if ((node.Left != null && node.Left.Value == value) || (node.Right != null && node.Right.Value == value))
                return node;

            return GetAncestorNode(node.Left, value) ?? GetAncestorNode(node.Right, value);
        }

        #endregion
        class Node
        {
            public Node(int value)
            {
                Value = value;
            }

            public int Value { get; }
            public Node Left { get; private set; }
            public Node Right { get; private set; }

            public bool IsLeaf()
            {
                return Left == null && Right == null;
            }

            public Node AssignOrGetNext(int value)
            {
                if (value > Value)
                {
                    if (Right != null)
                        return Right;

                    Right = new Node(value);
                }
                else
                {
                    if (Left != null)
                        return Left;

                    Left = new Node(value);
                }

                return null;
            }

            public Node Next(int value)
            {
                return value > Value ? Right : Left;
            }

            public bool IsBetween(int min, int max)
            {
                var a = Value > min && Value < max;
                return a;
            }
        }
    }
}
