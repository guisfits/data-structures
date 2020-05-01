using System;
using System.Linq;

namespace DataStructures.Algorithms
{
    public static class Searching
    {
        public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i;
            }

            return -1;
        }

        public static int BinarySearch(int[] array, int target)
        {
            if (array == null || array.Length == 0)
                return -1;

            return BinarySearch(array, target, 0, array.Length - 1);
        }

        private static int BinarySearch(int[] array, int target, int left, int right)
        {
            if (left >= right)
                return -1;

            var middleIndex = (left + right) / 2;
            var middleValue = array[middleIndex];

            if (middleValue == target)
                return middleIndex;

            if (target < middleValue)
                return BinarySearch(array, target, left, middleIndex - 1);

            return BinarySearch(array, target, middleIndex + 1, right);
        }

        public static int TernarySearch(int[] array, int target)
        {
            if (array == null || array.Length == 0)
                return -1;

            return TernarySearch(array, target, 0, array.Length - 1);
        }

        private static int TernarySearch(int[] array, int target, int left, int right)
        {
            if (left > right)
                return -1;

            var partitionSize = (right - left) / 3;
            int mid1 = left + partitionSize;
            int mid2 = right - partitionSize;

            if (array[mid1] == target)
                return mid1;

            if (array[mid2] == target)
                return mid2;

            if (target < array[mid1])
                return TernarySearch(array, target, left, mid1 - 1);

            if (target > array[mid2])
                return TernarySearch(array, target, mid2 + 1, right);

            return TernarySearch(array, target, mid1 + 1, mid2 - 1);
        }

        public static int ExponentialSearch(int[] array, int target)
        {
            if (array == null || array.Length == 0)
                return -1;

            if (array.Length == 1)
                return array[0] == target ? 0 : -1;

            array = array.OrderBy(x => x).ToArray();

            int bound = 1;
            while (bound < array.Length && array[bound] < target)
            {
                bound *= 2;
            }

            var left = bound / 2;
            var right = Math.Min(bound, array.Length - 1);

            return BinarySearch(array, target, left, right);
        }
    }
}
