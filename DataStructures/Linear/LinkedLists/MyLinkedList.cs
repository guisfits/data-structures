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
                throw new InvalidOperationException();

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
                throw new InvalidOperationException();

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

        public void Reverse()
        {
            if (IsEmpty())
                return;

            var previous = _first;
            var current = _first.Next;
            while (current != null)
            {
                var next = current.Next;
                current.Next = previous;

                previous = current;
                current = next;
            }

            _last = _first;
            _last.Next = null;
            _first = previous;
        }

        public T? GetByIndexBackward(int quantity)
        {
            if (IsEmpty() || quantity <= 0)
                return null;

            if (quantity == 1)
                return _last.Value;

            var first = _first;
            var second = GetDistancedNode(_first, quantity);
            if (second == null) return null;

            while (second != _last)
            {
                first = first.Next;
                second = second.Next;
            }

            return first.Value;
        }

        public T GetMiddleValue()
        {
            if (IsEmpty())
                return default(T);

            var head = _first;
            var tail = _first;

            while (tail != _last && tail.Next != _last)
            {
                head = head.Next;
                tail = tail.Next.Next;
            }

            return head.Value;
        }

        #region Private

        private bool IsEmpty()
        {
            return _first == null;
        }

        private Node GetDistancedNode(Node start, int distance)
        {
            var next = start;
            for (int i = 0; i < (distance - 1); i++)
            {
                if (next == null) break;
                next = next.Next;
            }

            return next;
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
            public Node(T value, Node next = null)
            {
                Value = value;
                Next = next;
            }

            public T Value { get; set; }
            public Node Next { get; set; }
        }

        #endregion
    }
}
