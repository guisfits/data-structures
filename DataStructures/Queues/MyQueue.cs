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
            Capacity = initialCapacity;
            _array = new T[Capacity];
        }

        #endregion

        public int Count => _count;
        public int Capacity
        {
            get => _capacity;
            private set
            {
                if (value < 1)
                    _capacity = 1;
                else
                    _capacity = value;
            }
        }

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

        private bool IsFull()
        {
            return (_tail + 1) == Capacity;
        }

        private void IncreaseCapacity()
        {
            Capacity = _count * 2;

            var newArray = new T[Capacity];
            var newArrayIndex = 0;

            for (int i = _head; i <= _tail; i++)
            {
                newArray[newArrayIndex] = _array[i];
                newArrayIndex++;
            }

            _array = newArray;
            _head = 0;
            _tail = _count - 1;
        }
    }
}
