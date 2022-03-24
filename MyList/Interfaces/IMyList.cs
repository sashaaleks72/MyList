namespace MyList.Interfaces
{
    public interface IMyList<T> : IEnumerable<T>
    {
        int Count { get; }

        int Capacity { get; }

        T this[int index] { get; set; }

        void Add(T item);

        void AddRange(IEnumerable<T> collection);

        void Remove(T item);

        void RemoveAt(int index);

        void Sort();
    }
}
