using System;

namespace ExceptionFilters
{
    static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("Another message");
            }
            catch (Exception ex) when (ex.Message == "Another message")
            {
                Console.WriteLine("Another message");
            }
            catch (Exception ex) when (ex.Message == "My Exception")
            {
                Console.WriteLine("My Exception");
            }
            Console.ReadKey();
        }
    }
}