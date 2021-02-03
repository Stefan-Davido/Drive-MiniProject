using System;
using System.Dynamic;

namespace _04_11Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hello {Name}");
            Venicles vans = new Venicles();
            vans.ChoseVenicle();
        }
    }
}
