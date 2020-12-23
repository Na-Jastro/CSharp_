using System;

namespace NullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            var name = person?.Name ?? "Name is null";

            Console.WriteLine(name);
            Console.ReadLine();
        }
        public class Person
        {
            public string Name { get; set; } = "Justice";
        }
    }
}
