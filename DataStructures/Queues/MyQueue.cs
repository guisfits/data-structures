namespace DataStructures.Queues
{
    public class MyQueue<T>
    {
        #region Constructor / Fields

        private T[] _array;
        private int _capacity;
        private int _head;
        private int _tail;
        private int _count;

        public MyQueue(int initialCapacity)
        {
            if (initialCapacity < 1) initialCapacity = 1;

            _capacity = initialCapacity;
            _array = new T[initialCapacity];
        }

        #endregion

        // [10, 20, 30, 40, 50]
        //  H               T

        public void Enqueue(T item)
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

            _array[_tail] = item;
            _count++;
        }

        public T Dequeue()
        {
            var item = Peek();
            _head++;
            _count--;

            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new System.Exception();

            return _array[_head];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _capacity;
        }
        private void IncreaseCapacity()
        {
            var newArray = new T[_capacity * 2];
            for (int i = 0; i < _capacity; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
            _capacity *= 2;
        }
    }
}
