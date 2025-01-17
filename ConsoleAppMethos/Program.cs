using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            feladat1();

            //Console.WriteLine("----------------");

            //feladat1();

            int result = feladat2multiply(3, 8);
            Console.WriteLine("The result is " + result);
            if (result % 2 == 0)
            // 2 / 2 = 1 - Even // 8 / 2 = 4 - Even // 3 / 2 = 1.5 - Even // 5 / 2 = 2.5 - Even                
                Console.WriteLine(result + "is an even number!");
            else
                Console.WriteLine(result + "is an uneven number!");
            
            feladat3();

            Console.ReadLine();
        }

        private static void feladat3()
        {   
            
        }

        private static int feladat2multiply(int num01, int num02)
        {
            int result = num01 * num02;
            return result;
        }

        private static void feladat1()
        {
            Random numberGen = new Random();
            string name = "x- " + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi, I'm " + name);
            Console.WriteLine("I'm " + age + " years old");
            Console.WriteLine("Oh, and I'n an alien.");
        }
    }
}
