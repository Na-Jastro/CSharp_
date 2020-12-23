using static System.Console;
using static System.Convert;

namespace UsingSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter value 1");
            int value1 = ToInt32(ReadLine());
            WriteLine("Enter value 2");
            int value2 = ToInt32(ReadLine());

            int sum = value1 + value2;
            WriteLine($"Sum {sum}");

            WriteLine("Hello World!");
            ReadLine();
        }
    }
}
