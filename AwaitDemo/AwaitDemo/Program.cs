using System;
using System.IO;
using System.Threading.Tasks;

namespace AwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoAlpha demoAlpha = new DemoAlpha();
            demoAlpha.MethodThrownException();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
    public class DemoAlpha
    {
        StreamReader reader = null;
        public async void MethodThrownException()
        {
            StreamReader reader =null;
            try
            {
                reader = new StreamReader(@"");
                string s = reader.ReadToEnd();
                Console.WriteLine(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                await Log();
            }
            finally
            {
                await Close();
            }
        }
        private async Task Log()
        {
            Console.WriteLine("Date :{0} &&  Time : {1}",DateTime.Now.ToLongDateString(),DateTime.Now.ToLongTimeString());
        }
        private async Task Close()
        {
            if (reader != null)
            {
                reader.Close();
            }
        }
    }
}
