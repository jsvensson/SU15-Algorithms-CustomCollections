namespace MyCollection
{
    public class MyStack<T> : MyCollection<T>
    {
        public override T Get()
        {
            return Collection[Count-1];
        }

        public override T GetAndRemove()
        {
            T item = Get();
            Collection.RemoveAt(Count-1);

            return item;
        }

        public void Push(T item)
        {
            Add(item);
        }

        public T Pop()
        {
            return GetAndRemove();
        }
    }
}
