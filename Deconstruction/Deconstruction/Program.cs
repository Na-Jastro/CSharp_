using System;

namespace Deconstruction
{
    class Program
    {
        static void Main(string[] args)
        {

            var (name, title, year) = GetTuple(1000);
            Console.WriteLine("Author {0} wrote his first book {1} in the year {2}", name, title, year);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static (string name, string title, int year) GetTuple(int id)
        {
            string name = string.Empty;
            string title = string.Empty;
            int year = 0;

            if (id == 1000)
            {
                name = "Justice";
                title = "C#";
                year = 2020;
            }

            return (name, title, year);
        }
    }
}
