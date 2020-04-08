using System;
using System.Collections.Generic;

namespace DataStructures.AVLTrees
{
    public class MyAVLTree
    {
        private Node _root;

        #region Insert

        public void Insert(params int[] values)
        {
            foreach (var value in values)
                Insert(value);
        }

        public void Insert(int value)
        {
            _root = Insert(_root, value);
        }

        private Node Insert(Node node, int value)
        {
            if (node == null)
                return new Node(value);

            if (value < node.Value)
                node.ChangeLeft(Insert(node.Left, value));
            else
                node.ChangeRight(Insert(node.Right, value));

            return Rebalance(node);
        }

        private Node Rebalance(Node root)
        {
            var rotation = GetRotationDirection(root);

            switch (rotation)
            {
                case Rotate.L:
                    root = root.RotateLeft();
                    break;

                case Rotate.LR:
                    root = root.RotateLeft();
                    root = root.RotateRight();
                    break;

                case Rotate.R:
                    root = root.RotateRight();
                    break;

                case Rotate.RL:
                    root = root.RotateRight();
                    root = root.RotateLeft();
                    break;

                case Rotate.None:
                default:
                    break;
            }

            return root;
        }

        #endregion

        #region GetRotationDirection

        public Rotate GetRotationDirection()
        {
            return GetRotationDirection(_root);
        }

        private Rotate GetRotationDirection(Node root)
        {
            var balance = root.GetBalance();

            if (balance == Balance.LeftHeavy)
            {
                var balanceFactor = root.Left.BalanceFactor;

                if (balanceFactor < 0)
                    return Rotate.LR;
                if (balanceFactor > 0)
                    return Rotate.R;
            }
            else if (balance == Balance.RightHeavy)
            {
                var balanceFactor = root.Right.BalanceFactor;

                if (balanceFactor > 0)
                    return Rotate.RL;
                if (balanceFactor < 0)
                    return Rotate.L;
            }

            return Rotate.None;
        }

        public enum Rotate { None, L, R, LR, RL }

        #endregion

        #region Contains

        public bool Contains(int value)
        {
            return FindNodeByValue(value) != null;
        }

        #endregion

        #region GetHeightOfValue

        public int GetHeightOfValue(int value)
        {
            return GetHeightOfValue(_root, value);
        }

        private int GetHeightOfValue(Node node, int value)
        {
            if (node == null)
                return -1;

            if (node.Value == value)
                return node.Height;

            return GetHeightOfValue(node.Next(value), value);
        }

        #endregion

        #region GetBalance

        public Balance GetBalance()
        {
            if (_root == null)
                return Balance.Balanced;

            return _root.GetBalance();
        }

        public enum Balance { Balanced, LeftHeavy, RightHeavy }

        #endregion

        #region GetAll

        public int[] GetAll()
        {
            var list = new List<int>();
            TraversePreOrder(_root, list);

            return list.ToArray();
        }

        private void TraversePreOrder(Node root, List<int> list)
        {
            if (root == null) return;
            list.Add(root.Value);
            TraversePreOrder(root.Left, list);
            TraversePreOrder(root.Right, list);
        }

        #endregion

        #region Helpers

        private Node FindNodeByValue(int value)
        {
            var current = _root;
            while (current != null)
            {
                if (current.Value == value)
                    return current;

                current = current.Next(value);
            }

            return null;
        }

        #endregion

        class Node
        {
            public Node(int value)
            {
                Value = value;
            }

            public int Value { get; }
            public int Height
            {
                get
                {
                    return Math.Max(Left?.Height ?? 0, Right?.Height ?? 0) + 1;
                }
            }

            public int BalanceFactor
            {
                get
                {
                    return (Left?.Height ?? 0) - (Right?.Height ?? 0);
                }
            }

            public Node Left { get; private set; }
            public Node Right { get; private set; }

            public override string ToString()
            {
                return $"Value={Value.ToString()}";
            }

            public bool IsLeaf()
            {
                return Left == null && Right == null;
            }

            public Balance GetBalance()
            {
                var balanceFactor = BalanceFactor;

                if (balanceFactor > 1)
                    return Balance.LeftHeavy;
                if (balanceFactor < -1)
                    return Balance.RightHeavy;

                return Balance.Balanced;
            }

            public Node Next(int value)
            {
                return value > Value ? Right : Left;
            }

            public void ChangeRight(Node node)
            {
                this.Right = node;
            }

            public void ChangeLeft(Node node)
            {
                this.Left = node;
            }

            public Node RotateLeft()
            {
                var newRoot = this.Right;
                this.ChangeRight(this.Left);
                newRoot.ChangeLeft(this);

                return newRoot;
            }

            public Node RotateRight()
            {
                var newRoot = this.Left;
                this.ChangeLeft(this.Right);
                newRoot.ChangeRight(this);

                return newRoot;
            }
        }
    }
}
