namespace System.Collections.Generic
{
    public static class DictionaryExtensions
    {
        public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key)
            where TValue : class
        {
            TValue value;
            if(!dic.TryGetValue(key, out value))
                return null;

            return value;
        }
    }
}
