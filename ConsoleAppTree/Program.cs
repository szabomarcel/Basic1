using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows;
            Console.WriteLine("Enter number of rows: ");
            rows = int.Parse(Console.ReadLine());            
            for (int i = 1; i<= rows; i++)
            {
                for (int space = 1;  space <= rows; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= i; star++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
