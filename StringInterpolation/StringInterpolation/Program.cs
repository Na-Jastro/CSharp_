using System;
using static System.Console;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "C#";
            int age = 16;

            string message = $"{name} is {age} years old";

            WriteLine(message);

            WriteLine("Hello World!");
            ReadKey();
        }
    }
}
