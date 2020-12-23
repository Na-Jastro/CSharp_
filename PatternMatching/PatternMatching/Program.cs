using System;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            author.name = "Harish";
            author.age = 25;
            author.sex = "Male";
            author.book_title = "NodeJs";
            author.pub_year = 2020;

            Reader reader = new Reader();
            reader.name = "Justice";
            reader.age = 30;
            reader.sex = "Male";
            reader.interest = "Reading";
            reader.job = "Software Developer";


            if (author is Person)
            {
                Console.WriteLine("author is person.");
            }
            else
            {
                Console.WriteLine("author is not person.");
            }

            if (author is Reader)
            {
                Console.WriteLine("author is person.");
            }
            else
            {
                Console.WriteLine("author is not person.");
            }

            switch (author)
            {
                case Author author1 when (author1.age == 256):
                    Console.WriteLine(author1.name);
                    break;
                default:
                    Console.WriteLine("Invalid pattern match");
                    break;
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }

    class Person
    {
        public string name;
        public int age;
        public string sex;
    }

    class Author : Person
    {
        public string book_title;
        public int pub_year;
    }
    class Reader : Person
    {
        public string interest;
        public string job;
    }
}
