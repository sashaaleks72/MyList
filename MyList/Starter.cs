using MyList.Containers;
using MyList.Interfaces;

namespace MyList
{
    public class Starter
    {
        public void Run()
        {
            IMyList<string> list = new MyList<string>(3);
            list.Add("Hello");
            list.Add("my");
            list.Add("lovely");
            list.Add("world!");
            list.AddRange(new string[] { "Slava", "Ukraine!" });
            list.AddRange(new string[] { "Heroes", "Slava!" });

            Console.WriteLine(list.Capacity + " - " + list.Count);
            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }

            Console.WriteLine("\n");

            list.RemoveAt(0);
            list.Remove("Slava");

            Console.WriteLine(list.Capacity + " - " + list.Count);
            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }

            Console.WriteLine("\n");

            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
        }
    }
}
