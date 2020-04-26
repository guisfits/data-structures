using System;

namespace DataStructures
{
    public class MyArrayList
    {
        private int[] _array;
        public MyArrayList(int size)
        {
            _array = new int[size];
        }

        public void Insert(int number)
        {
            int index = FindIndex(0);
            if (index >= 0)
            {
                _array[index] = number;
            }
            else
            {
                var newArray = Copy(_array, 1);
                _array = Copy(newArray);
                newArray = null;

                _array[_array.Length - 1] = number;
            }
        }

        public void RemoveAt(int index)
        {
            _array[index] = 0;
            var newArray = Copy(_array);

            _array = new int[newArray.Length - 1];

            var arrayIndex = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                var value = newArray[i];
                if (value > 0)
                {
                    _array[arrayIndex] = value;
                    arrayIndex++;
                }
            }
        }

        public int[] ToArray()
        {
            return _array;
        }

        private int[] Copy(int[] array, int plusSize = 0)
        {
            var newArray = new int[array.Length + plusSize];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        private int FindIndex(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                var arrayValue = _array[i];
                if (arrayValue == value)
                    return i;
            }

            return -1;
        }
    }
}
