using DataStructures.Queues;

namespace DataStructures.Tests.Queues.MyQueueTests
{
    public class Base
    {
        protected static MyQueue<int> Create(int quantity)
        {
            var queue = new MyQueue<int>(quantity);

            for (int i = 1; i <= quantity; i++)
                queue.Enqueue(i * 10);

            return queue;
        }
    }
}
