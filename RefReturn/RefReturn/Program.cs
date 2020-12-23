using System;

namespace RefReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an Array of Numbers
            int[] numbers = { 1, 2, 3, 4, 5 };

            //Call a method that returns by ref
            ref int item = ref GiveMeNumber(numbers, 2);

            //Prints 3rd in an Array = 3
            Console.WriteLine(item);

            //Replace 3rd number by some new number. By ref Key word, it will update the array.
            item = 40;

            Console.WriteLine(numbers[2]);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static ref int GiveMeNumber(int[] arr, int index)
        {
            return ref arr[index];
        }
    }
}
