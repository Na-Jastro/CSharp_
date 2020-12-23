using System;

namespace BinaryLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            var value0 = 0b0;
            var value1 = 0b1;
            var value2 = 0B10;
            var value3 = 0b11;

            var value4 = 0b11111111;

            var value6 = value4 + value3;

            Console.WriteLine(value0);
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);

            Console.WriteLine(value4);
            Console.WriteLine(value6);

            Console.WriteLine(value0.GetType());
            
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
