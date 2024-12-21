using System;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Write a:");
            string? s = Console.ReadLine();

            int a;
            int b;
            
            while (!Int32.TryParse(s, out a))
            {
                Console.WriteLine("Wrong a!");
                Console.WriteLine("Write a again:");
                s = Console.ReadLine();
            }
                
            Console.WriteLine("Write b:");
            s = Console.ReadLine();
            
            while (!Int32.TryParse(s, out b))
            {
                Console.WriteLine("Wrong b!");
                Console.WriteLine("Write b again:");
                s = Console.ReadLine();
            }
            
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}
