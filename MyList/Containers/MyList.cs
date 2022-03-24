using System.Collections;
using MyList.Interfaces;

namespace MyList.Containers
{
    public class MyList<T> : IMyList<T>
    {
        public MyList()
        {
            Capacity = 0;
            MyArray = new T[Capacity];
        }

        public MyList(int capacity)
        {
            Capacity = capacity;
            MyArray = new T[Capacity];
        }

        public int Count { get; private set; }

        public int Capacity { get; private set; }

        private T[] MyArray { get; set; }

        public T this[int index]
        {
            get => MyArray[index];
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                MyArray[index] = value;
            }
        }

        public void Add(T item)
        {
            if (Capacity <= Count)
            {
                RaiseCapacity();
            }

            Count++;
            MyArray[Count - 1] = item;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            for (int i = 0; i < collection.Count(); i++)
            {
                if (Capacity <= Count)
                {
                    RaiseCapacity();
                }

                Count++;
                MyArray[Count - 1] = collection.ToList()[i];
            }
        }

        public void Remove(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            T[] tempArr = new T[Capacity];
            bool isEqual = false;

            int j = 0;
            for (int i = 0; i < Count; i++)
            {
                if (MyArray[i].Equals(item) && isEqual == false)
                {
                    isEqual = true;
                    continue;
                }

                tempArr[j++] = MyArray[i];
            }

            MyArray = tempArr;
            Count--;
        }

        public void RemoveAt(int index)
        {
            Remove(MyArray.ElementAt(index));
        }

        public void Sort()
        {
            Array.Sort(MyArray, 0, Count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in MyArray)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private void RaiseCapacity()
        {
            if (Capacity <= 0)
            {
                Capacity = 4;
                MyArray = new T[Capacity];
            }
            else
            {
                Capacity *= 2;
                T[] tempArr = new T[Capacity];

                for (int i = 0; i < Count; i++)
                {
                    tempArr[i] = MyArray[i];
                }

                MyArray = tempArr;
            }
        }
    }
}
