using System.Linq;

namespace DataStructures.Algorithms
{
    public static class Sorting
    {
        public static int[] BubbleSort(int[] array)
        {
            if (array == null)
                return null;

            var isSorted = false;

            for (var i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(array, i, i + 1);
                    isSorted = true;
                }
            }

            if (isSorted)
                return BubbleSort(array);

            return array;
        }

        public static int[] SelectSort(int[] array)
        {
            if (array == null) return null;

            for (var i = 0; i < array.Length; i++)
            {
                int min = array[i];
                int minIndex = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                    Swap(array, i, minIndex);
            }

            return array;
        }

        public static int[] InsertSort(int[] array)
        {
            if (array == null) return null;

            for (int i = 1; i < array.Length; i++)
            {
                var current = array[i];
                int j = i - 1;
                while (j >= 0 && array[i] < array[j])
                {
                    array[j] = array[j + 1];
                    j--;
                }

                array[j + 1] = current;
            }

            return array;
        }

        public static void MergeSort(int[] array)
        {
            if(array == null || array.Length < 2)
                return;

            var middleIndex = array.Length / 2;

            var left = array.Take(middleIndex).ToArray();
            var right = array.Skip(middleIndex).Take(array.Length - middleIndex).ToArray();

            MergeSort(left);
            MergeSort(right);

            Merge(left, right, array);
        }

        #region Privates

        private static void Swap(int[] array, int indexA, int indexB)
        {
            var temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexA + 1] = temp;
        }

        private static void Merge(int[] left, int[] right, int[] result) {
            int i, j, k;
            i = j = k = 0;

            while(i < left.Length && k < right.Length) {
                if(left[i] <= right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while(i < left.Length)
                result[k++] = left[i++];

            while(j < right.Length)
                result[k++] = right[j++];
        }

        #endregion
    }
}
