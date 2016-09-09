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
    }
}
