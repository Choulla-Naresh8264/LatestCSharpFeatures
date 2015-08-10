using System;

namespace StringInterPolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.Write($"First Name:{student.FirstName}");
            Console.Write($"Last Name:{student.LastName}");
            Console.ReadKey();
        }
    }
}
