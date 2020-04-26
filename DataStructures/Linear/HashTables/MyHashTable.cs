using System.Collections.Generic;

namespace DataStructures.HashTables
{
    public class MyHashTable<TKey, TValue>
    {
        #region Constructor

        private LinkedList<Entry>[] _array;
        private const int _size = 100;

        public MyHashTable()
        {
            _array = new LinkedList<Entry>[_size];
        }

        #endregion

        public void Put(TKey key, TValue value)
        {
            Remove(key);
            GetList(key).AddLast(new Entry(key, value));
        }

        public TValue Get(TKey key)
        {
            var entry = FindEntryByKey(key);
            return entry != null ? entry.Value : default(TValue);
        }

        public void Remove(TKey key)
        {
            var entry = FindEntryByKey(key);
            if (entry != null) GetList(key).Remove(entry);
        }

        #region Privates
            
        private LinkedList<Entry> GetList(TKey key)
        {
            var index = key.GetHashCode() % _size;

            if (_array[index] == null)
                _array[index] = new LinkedList<Entry>();

            return _array[index];
        }

        private Entry FindEntryByKey(TKey key)
        {
            foreach (var entry in GetList(key))
                if (entry.Key.Equals(key))
                    return entry;

            return null;
        }

        #endregion

        class Entry
        {
            public Entry(TKey key)
            {
                Key = key;
            }

            public Entry(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }

            public TKey Key { get; }
            public TValue Value { get; private set; }

            public void ChangeValue(TValue newValue)
            {
                this.Value = newValue;
            }
        }
    }
}
