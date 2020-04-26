namespace DataStructures.Algorithms
{
    public static class Sorting
    {
        public static int[] BubbleSort(int[] array)
        {
            if(array == null)
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

        private static void Swap(int[] array, int indexA, int indexB)
        {
            var temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexA + 1] = temp;
        }
    }
}
