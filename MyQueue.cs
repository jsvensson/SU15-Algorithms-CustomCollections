using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    public class MyQueue<T> : IMyCollection<T>
    {
        private List<T> collection;

        public int Count => collection.Count;

        public MyQueue()
        {
            collection = new List<T>();
        }

        public void Add(T item)
        {
            collection.Add(item);
        }

        public void Clear()
        {
            collection.Clear();
        }

        public bool Contains(T item)
        {
            return collection.Contains(item);
        }

        public T Get()
        {
            return collection[0];
        }

        public T GetAndRemove()
        {
            T item = Get();
            collection.RemoveAt(0);

            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)collection).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
