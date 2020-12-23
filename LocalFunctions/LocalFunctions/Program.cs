using System;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            //int Add() => a + b;

            int Add()
            {
                return a + b;
            }

            Console.WriteLine(Add());

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

    }
}
