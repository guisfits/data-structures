namespace DataStructures.Queues
{
    public class MyQueue<T>
    {
        #region Constructor / Fields

        protected T[] _array;
        protected int _capacity;
        protected int _head;
        protected int _tail;
        protected int _count;

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
            protected set
            {
                if (value < 1)
                    _capacity = 1;
                else
                    _capacity = value;
            }
        }

        public virtual void Enqueue(T item)
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

        public virtual T Dequeue()
        {
            var item = Peek();
            _head++;
            _count--;

            return item;
        }

        public virtual T Peek()
        {
            if (IsEmpty())
                throw new System.Exception();

            return _array[_head];
        }

        public virtual bool IsEmpty()
        {
            return _count == 0;
        }

        protected virtual bool IsFull()
        {
            return (_tail + 1) == Capacity;
        }

        protected virtual void IncreaseCapacity()
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
