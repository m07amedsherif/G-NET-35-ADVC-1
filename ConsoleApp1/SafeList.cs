using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SafeList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }

            return default(T);
        }
    }
}
