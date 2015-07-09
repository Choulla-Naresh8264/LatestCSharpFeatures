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
        }
    }

    public class Student
    {
        public int Id { get; set; }=1;
        public string FirstName {get;set;}="Jalpesh";
        public string LastName {get;set;}="Vadgama";
    }
}
