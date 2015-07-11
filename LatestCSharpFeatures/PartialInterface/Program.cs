using System;

namespace PartialInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person = new Person();
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.ReadKey();
        }
    }

    public partial interface IPerson
    {
        string FirstName { get; set; }
    }
    public partial interface IPerson
    {
        string LastName { get; set; }
    }

    public class Person : IPerson
    {
        public string FirstName
        {
           get;set;
        }= "Jalpesh";

        public string LastName
        {
            get;set;
        }="Vadgama";
    }
}
