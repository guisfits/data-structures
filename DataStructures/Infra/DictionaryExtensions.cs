namespace System.Collections.Generic
{
    public static class DictionaryExtensions
    {
        public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key)
        {
            TValue value;
            if (!dic.TryGetValue(key, out value))
                return default(TValue);

            return value;
        }

        public static TValue GetValueOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key)
            where TValue : new()
        {
            if (!dic.ContainsKey(key))
            {
                dic.Add(key, new TValue());
            }

            return dic.GetValue(key);
        }
    }
}
