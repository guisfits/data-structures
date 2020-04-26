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

        #region Privates

        private static void Swap(int[] array, int indexA, int indexB)
        {
            var temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexA + 1] = temp;
        }

        #endregion
    }
}
