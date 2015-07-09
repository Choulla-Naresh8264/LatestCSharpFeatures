using System;
using System.Collections.Generic;

namespace AutoPropertyIntializers
{
    class Program
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
            
        }
    }

    public class Employee
    {
        public Guid Id {get;set;}= Guid.NewGuid();
        public string FirstName {get;set;}
        public string LastName {get;set;}
    }
}
