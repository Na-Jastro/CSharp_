using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>()
            {
                [1] = "C#",
                [2] = "Asp.net MVC",
                [3] = "Html",
                [4] = "Javascript"
            };

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
