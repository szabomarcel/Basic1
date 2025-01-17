using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write the title. Change the appearance
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;


            // Console write. Get a conversation going.
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello, what's your name?");
            Console.ReadLine(); // This works too
            Console.WriteLine("My nam is RX-9000. I'n ab AI sent from zhr future to destroy mankin");
            Console.WriteLine("What is your favorite color");
            Console.ReadLine();
            Console.WriteLine("Cool! Mane is destruction.");


            Console.ReadKey();
        }
    }
}
