namespace MyCollection
{
    public class MyQueue<T> : MyCollection<T>
    {
        public override T Get()
        {
            return Collection[0];
        }

        public override T GetAndRemove()
        {
            T item = Get();
            Collection.RemoveAt(0);

            return item;
        }

        public void Enqueue(T item)
        {
            Add(item);
        }

        public T Dequeue()
        {
            return GetAndRemove();
        }
    }
}
