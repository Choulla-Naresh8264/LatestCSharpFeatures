using System;

namespace ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("My Exception");
            }
            catch (Exception ex) when (ex.Message == "Another message")
            {
                Console.WriteLine("Another message exception");
            }
            catch (Exception ex) when (ex.Message == "My Exception")
            {
                Console.WriteLine("My Exception exception");
            }
            Console.ReadKey();
        }
    }
}