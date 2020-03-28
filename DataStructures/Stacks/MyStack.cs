namespace DataStructures.Stacks
{
    public class MyStack<T> 
    {
        private T[] _array;
        private int _capacity;
        private int _count;

        public MyStack(int initialCapacity = 5)
        {
            _array = new T[initialCapacity];
            _capacity = initialCapacity;
            _count = -1;
        }

        public int Size => _count + 1;

        public void Push(T item)
        {
            if ((_count + 1) == _capacity)
                IncreaseCapacity();

            _count++;
            _array[_count] = item;
        }

        public T Pop()
        {
            if (IsEmpty()) throw new System.IndexOutOfRangeException();

            var item = Peek();
            _array[_count] = default(T);
            _count--;

            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new System.IndexOutOfRangeException();

            return _array[_count];
        }

        public bool IsEmpty()
        {
            return _count == -1;
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
