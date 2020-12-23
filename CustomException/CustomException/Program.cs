using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 10;
            int j = 0;

            try
            {
                if (j > 0)
                {
                    Console.WriteLine("Result :" + i / j);
                }
                else
                {
                    throw new MyException("We cannot divide number by Zero");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
