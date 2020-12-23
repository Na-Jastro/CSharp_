using System;

namespace AutoProperty
{
    class Employee
    {
        public int Id { get; set; } = 101;
        public string Name { get; set; } = "C#";
        public string Department { get; set; } = "Programming";

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
