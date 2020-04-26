namespace DataStructures.Algorithms.Sorting
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] array)
        {
            var wasSorted = false;

            for (var i = 0; i < array.Length - 1; i++)
            {
                if(array[i] > array[i + 1])
                {
                    var temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;

                    wasSorted = true;
                }
            }

            if (wasSorted)
                return Sort(array);

            return array;
        }
    }
}
