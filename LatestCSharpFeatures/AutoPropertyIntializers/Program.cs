using System;

namespace AutoPropertyIntializers
{
    static class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                FirstName ="Jalpesh",
                LastName ="Vadgama"
            };

            Console.WriteLine("Printing Employee");
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
            Console.ReadKey();
        }
    }
}
