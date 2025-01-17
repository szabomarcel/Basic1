using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // loop
            feladat1();

            // while loop 
            feladat2();

            Console.ReadKey();
        }

        private static void feladat2()
        {
            Random numberGen = new Random();
            //numberGen.Next(0, 4);
            int roll = 0;
            int attempts = 0;
            Console.WriteLine("Press enter to roll the die.");
            while (roll != 6)
            {
                Console.ReadLine();
                roll = numberGen.Next(1, 7);
                Console.WriteLine("You rolled: " + roll);
                attempts++;
            }
            Console.WriteLine("It took you " + attempts + " attempts to roll a six.");

        }

        private static void feladat1()
        {

            /*for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }*/

            Console.Write("How many cool numbers do you want: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                double result = Math.Pow(2, i); 
                Console.WriteLine(result);
            }
        }
    }
}
