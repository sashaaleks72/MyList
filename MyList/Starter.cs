using MyList.Interfaces;

namespace MyList
{
    public class Starter
    {
        public Starter(IMyList<string> myList)
        {
            MyList = myList;
        }

        public IMyList<string> MyList { get; set; }

        public void Run()
        {
            MyList.Add("Hello");
            MyList.Add("my");
            MyList.Add("lovely");
            MyList.Add("world!");
            MyList.AddRange(new string[] { "Slava", "Ukraine!" });
            MyList.AddRange(new string[] { "Heroes", "Slava!" });

            Console.WriteLine(MyList.Capacity + " - " + MyList.Count);
            Console.WriteLine();

            foreach (var item in MyList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n");

            MyList.RemoveAt(0);
            MyList.Remove("Slava");

            Console.WriteLine(MyList.Capacity + " - " + MyList.Count);
            Console.WriteLine();

            foreach (var item in MyList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n");

            MyList.Sort();

            Console.WriteLine(MyList.Capacity + " - " + MyList.Count);
            Console.WriteLine();

            foreach (var item in MyList)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
