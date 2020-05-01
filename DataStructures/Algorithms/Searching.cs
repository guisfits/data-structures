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
    }
}
