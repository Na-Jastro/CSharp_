using System;

namespace ExpressionBodiesMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetTime());
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        public static string GetTime() => "Current Time: - " + DateTime.Now.ToString("hh:mm:ss");
    }
}
