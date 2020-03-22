using System;

namespace DataStructures.LinkedLists
{
    public class MyLinkedList<T> where T : struct, IEquatable<T>
    {
        private Node _first;
        private Node _last;
        private int _size;

        public MyLinkedList()
        {
            _size = 0;
        }

        public T? GetFirst()
        {
            return _first?.Value;
        }

        public T? GetLast()
        {
            return _last?.Value;
        }

        public void AddFirst(T value)
        {
            var node = new Node(value);
            if (IsEmpty())
            {
                _first = _last = node;
            }
            else
            {
                node.Next = _first;
                _first = node;
            }

            _size++;
        }

        public void AddLast(T value)
        {
            var node = new Node(value);
            if (IsEmpty())
            {
                _first = _last = node;
            }
            else
            {
                _last.Next = node;
                _last = node;
            }

            _size++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException();

            if (_first == _last)
            {
                _first = _last = null;
            }
            else
            {
                var second = _first.Next;
                _first.Next = null;
                _first = second;
            }

            _size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException();

            if (_first == _last)
            {
                _first = _last = null;
            }
            else
            {
                // [1 -> 2 -> 3]
                _last = GetPrevious(_last);
                _last.Next = null;
            }

            _size--;
        }

        public bool Contains(T value)
        {
            return IndexOf(value) != -1;
        }

        public int IndexOf(T value)
        {
            if (IsEmpty() == false)
            {
                var index = 0;
                var current = _first;
                while (current != null)
                {
                    if (current.Value.Equals(value)) return index;
                    current = current.Next;
                    index++;
                }
            }

            return -1;
        }

        public int Size()
        {
            return _size;
        }

        public T[] ToArray()
        {
            var array = new T[_size];

            var index = 0;
            var current = _first;
            while (current != null)
            {
                array[index] = current.Value;
                current = current.Next;
                index++;
            }

            return array;
        }

        #region Private

        private bool IsEmpty()
        {
            return _first == null;
        }

        private Node GetPrevious(Node node)
        {
            var current = _first;
            while (current != null)
            {
                if (current.Next == node)
                    return current;

                current = current.Next;
            }

            return null;
        }

        class Node
        {
            public Node(T value)
            {
                Value = value;
            }

            public T Value { get; set; }
            public Node Next { get; set; }

            public bool IsPrevious(Node next)
            {
                return Next != null && Next == next;
            }

            public bool HasValue(T value)
            {
                return Value.Equals(value);
            }
        }

        #endregion
    }
}
