using System;
using System.Linq;

namespace DataStructures.Heaps
{
    public class MyHeap
    {
        private int[] _array;
        private int _size;

        public MyHeap(int initialCapacity = 10)
        {
            _array = new int[initialCapacity];
            _size = 0;
        }

        public void Insert(params int[] values)
        {
            foreach (var value in values)
                Insert(value);
        }

        public void Insert(int value)
        {
            if (_size == _array.Count()) throw new Exception();
            _array[_size++] = value;
            BubbleUp();
        }

        public int Remove()
        {
            if (IsEmpty()) throw new Exception();

            var oldRoot = _array[0];
            _array[0] = _array[--_size];
            BubbleDown();

            return oldRoot;
        }

        public int[] GetAll()
        {
            return _array.Take(_size).ToArray();
        }

        #region Privates

        private void BubbleUp()
        {
            var index = _size - 1;
            while (index > 0 && _array[index] > _array[GetIndexOfTheParent(index)])
            {
                Swap(index, GetIndexOfTheParent(index));
                index = GetIndexOfTheParent(index);
            }
        }

        private void BubbleDown()
        {
            var index = 0;
            while (index <= _size && IsValidParent(index) == false)
            {
                int largerIndex = LargerChildIndex(index);
                Swap(index, largerIndex);
                index = largerIndex;
            }
        }

        private void Swap(int first, int second)
        {
            var newSecond = _array[first];
            _array[first] = _array[second];
            _array[second] = newSecond;
        }

        private bool IsValidParent(int index)
        {
            if (HasLeftChild(index) == false)
                return true;

            var isValid = _array[index] >= LeftChild(index);

            if (HasRightChild(index) == false)
                isValid = isValid && _array[index] >= RightChild(index);

            return isValid;
        }

        private bool IsEmpty()
        {
            return _size == 0;
        }

        private int GetIndexOfLeftChild(int parentIndex)
        {
            return (parentIndex * 2) + 1;
        }

        private int GetIndexOfRightChild(int parentIndex)
        {
            return (parentIndex * 2) + 2;
        }

        private int GetIndexOfTheParent(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        private int LargerChildIndex(int index)
        {
            if (HasLeftChild(index) == false)
                return index;

            if (HasRightChild(index) == false)
                return GetIndexOfLeftChild(index);

            return LeftChild(index) > RightChild(index) ?
                GetIndexOfLeftChild(index) :
                GetIndexOfRightChild(index);
        }

        private int RightChild(int index)
        {
            return _array[GetIndexOfRightChild(index)];
        }

        private int LeftChild(int index)
        {
            return _array[GetIndexOfLeftChild(index)];
        }

        private bool HasLeftChild(int index)
        {
            return GetIndexOfLeftChild(index) <= _size;
        }

        private bool HasRightChild(int index)
        {
            return GetIndexOfRightChild(index) <= _size;
        }

        #endregion
    }
}
