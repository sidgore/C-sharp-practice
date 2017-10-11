using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("\nWhat is your name? ");

            var name = Console.ReadLine();
            var date = DateTime.Now;

            Console.Clear();
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.WriteLine("Hello World!");
           
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
