using System;

namespace PartialInterface
{
    static class Program
    {
        static void Main(string[] args)
        {
            IPerson person = new Person();
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.ReadKey();
        }
    }
}
