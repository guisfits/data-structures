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
            if(array == null || array.Length == 0)
                return -1;

            var middleIndex = array.Length / 2;
            var middleValue = array[middleIndex];

            if(middleValue == target)
                return middleIndex;

            if(middleIndex < target)            
                return BinarySearch(array.Take(middleIndex + 1).ToArray(), target);

            return BinarySearch(array.Skip(middleIndex + 1).Take(array.Length).ToArray(), target);
        }
    }
}
