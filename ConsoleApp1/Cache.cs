using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cache<TKey, TValue>
    {
        private class CacheItem
        {
            public TValue Value { get; set; }
            public DateTime ExpirationTime { get; set; }
        }

        private Dictionary<TKey, CacheItem> items = new Dictionary<TKey, CacheItem>();

        public void Add(TKey key, TValue value, TimeSpan duration)
        {
            items[key] = new CacheItem
            {
                Value = value,
                ExpirationTime = DateTime.Now.Add(duration)
            };
        }

        public TValue Get(TKey key)
        {
            if (items.ContainsKey(key))
            {
                CacheItem item = items[key];

                if (DateTime.Now <= item.ExpirationTime)
                {
                    return item.Value;
                }

                items.Remove(key);
            }

            return default(TValue);
        }

        public bool Remove(TKey key)
        {
            return items.Remove(key);
        }

        public bool Contains(TKey key)
        {
            if (items.ContainsKey(key))
            {
                if (DateTime.Now <= items[key].ExpirationTime)
                {
                    return true;
                }

                items.Remove(key);
            }

            return false;
        }
    }

}
