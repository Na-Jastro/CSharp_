using System;

namespace NameO4fDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine("{0}:{1}", nameof(Employee.Id), employee.Id);
            Console.WriteLine("{0}:{1}", nameof(Employee.Name), employee.Name);
            Console.WriteLine("{0}:{1}", nameof(Employee.Salary), employee.Salary);
            
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public int Id { get; set; } = 101;
        public string Name { get; set; } = "CSharp";
        public int Salary { get; set; } = 99;

    }
}
