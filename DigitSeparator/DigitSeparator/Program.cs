using System;

namespace DigitSeparator
{
    class Program
    {

        static void Main(string[] args)
        {
            int bin = 0b1001_1010_0001_0100;

            int data = 123_45_67__________89;

            double wee =  1_000.111_1e-1_000;

            float foof = 10.25f;

            Console.WriteLine(bin);
            Console.WriteLine(data);
            Console.WriteLine(wee);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
