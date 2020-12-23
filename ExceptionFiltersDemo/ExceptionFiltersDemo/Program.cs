using System;

namespace ExceptionFiltersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpstatuscode = 402;
            Console.Write("Http status code :");

            try
            {
                throw new Exception(httpstatuscode.ToString());
            }
            catch (Exception ex) when (ex.Message.Equals("400"))
            {
                Console.Write("Bad Request");
                Console.ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("401"))
            {
                Console.Write("Unathorised");
                Console.ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("402"))
            {
                Console.Write("Payment Required");
                Console.ReadLine();
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
