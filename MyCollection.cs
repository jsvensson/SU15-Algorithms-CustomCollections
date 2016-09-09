using System.Collections;
using System.Collections.Generic;

namespace MyCollection
{
    public abstract class MyCollection<T> : IMyCollection<T>
    {
        protected virtual List<T> Collection { get; set; } = new List<T>();

        public virtual int Count => Collection.Count;

        public T this[int index]
        {
            get { return Collection[index]; }
            set { Collection[index] = value; }
        }

        public void Add(T item)
        {
            Collection.Add(item);
        }

        public void Add(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }

        public abstract T Get();

        public abstract T GetAndRemove();

        public void Clear()
        {
            Collection.Clear();
        }

        public bool Contains(T item)
        {
            return Collection.Contains(item);
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)Collection).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
