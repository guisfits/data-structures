using System.Linq;

namespace DataStructures.Heaps
{
    public static class Exercises
    {
        #region Heapify

        public static int[] Heapify(int[] array)
        {
            var countParents = (array.Count() / 2) - 1;
            for (int i = countParents; i >= 0; i--)
                Heapify(array, i);

            return array;
        }

        private static void Heapify(int[] array, int index)
        {
            var largerIndex = index;

            var leftIndex = index * 2 + 1;
            if (leftIndex < array.Count() && array[leftIndex] > array[largerIndex])
                largerIndex = leftIndex;

            var rightIndex = index * 2 + 2;
            if (rightIndex < array.Count() && array[rightIndex] > array[largerIndex])
                largerIndex = rightIndex;

            if (largerIndex == index)
                return;

            Swap(array, index, largerIndex);
            Heapify(array, largerIndex);
        }

        private static void Swap(int[] array, int index, int largerIndex)
        {
            var temp = array[index];
            array[index] = array[largerIndex];
            array[largerIndex] = temp;
        }

        #endregion

        #region FindKthLargestItem

        public static int FindKthLasgestItem(MyHeap heap, int k)
        {
            int largest = 0;
            while (k > 0)
            {
                largest = heap.Remove();
                k--;
            }

            return largest;
        }

        #endregion
    }
}
