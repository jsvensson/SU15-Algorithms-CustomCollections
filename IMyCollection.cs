using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    interface IMyCollection<T> : IEnumerable<T>
    {
        void Add(T item);  // Enqueue/Push
        T Get();  // Peek
        T GetAndRemove(); // Dequeue/Pop
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
}
