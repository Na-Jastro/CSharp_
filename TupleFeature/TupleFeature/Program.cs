using System;

namespace TupleFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            ////using tuple constructor
            //var author = new Tuple<string, string, int>("Justice", "C# Programming", 2010);
            //Console.WriteLine("Author {0} wrote his first book titled {1} in {2}", author.Item1, author.Item2, author.Item3);


            ////using create Method

            //var pubAuthor = Tuple.Create("Justice", "SQL", 2030);
            //Console.WriteLine("Author {0} wrote his first book titled {1} in {2}", pubAuthor.Item1, pubAuthor.Item2, pubAuthor.Item3);

            TupleSamples tupleSamples = new TupleSamples();
            var author = tupleSamples.TupleReturn(1000);

            Console.WriteLine("Author {0} wrote first book titled {1} in the year {2}", author.Item1,author.Item2,author.Item3);


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }

    class TupleSamples
    {
        public (string name,string title,long year) TupleReturn(long id)
        {
            string name = string.Empty;
            string title = string.Empty;
            long year = 0;


            if(id == 1000)
            {
                name = "Justice";
                title = "C#";
                year = 2020;
            }

            return (name, title, year);
        }
    }
}
