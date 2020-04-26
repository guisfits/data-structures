using System.Collections.Generic;

namespace DataStructures.Queues
{
    public static class Exercises
    {
        public static Queue<T> Reverse<T>(Queue<T> queue)
        {
            if (queue == null) return null;

            var originalSize = queue.Count;
            var items = new T[originalSize];

            var index = 0;
            while (queue.Count > 0)
            {
                items[index] = queue.Dequeue();
                index++;
            }

            for (int i = originalSize; i > 0; i--)
                queue.Enqueue(items[i - 1]);

            return queue;
        }
    }
}
