using System;

namespace OutVariable
{
    class Program
    {
        public static void AssignedValue(out string strName)
        {
            strName = "Im From Out";
            Console.WriteLine(strName);
        }

        static void Main(string[] args)
        {

            AssignedValue(out string strArgu);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
