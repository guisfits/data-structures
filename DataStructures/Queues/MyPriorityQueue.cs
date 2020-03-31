namespace DataStructures.Queues
{
    public class MyPriorityQueue : MyQueue<int>
    {
        public MyPriorityQueue(int initialCapacity) : base(initialCapacity) { }

        public override void Enqueue(int item)
        {
            if (IsFull())
                IncreaseCapacity();

            if (IsEmpty())
            {
                _head = 0;
                _tail = 0;
            }
            else
            {
                _tail++;
            }

            var orderIndex = _tail;
            while ((orderIndex - 1) >= _head)
            {
                if (_array[orderIndex - 1] <= item)
                    break;

                _array[orderIndex] = _array[orderIndex - 1];
                orderIndex--;
            }

            _array[orderIndex] = item;
            _count++;
        }
    }
}
