using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            feladat1();
            feladat2();
            feladat3();

            // Wait before closing
            Console.ReadLine();
        }

        private static void feladat3()
        {
            string szoveg = "\tEz egy alma";
            int isnetlesekSzama = 100;
            //StringBuilder eredmeny = new StringBuilder();
            for (int i = 0; i < isnetlesekSzama; i++)
            {
                /*eredmeny.Append(szoveg);
                if (i < isnetlesekSzama - 1)
                {
                    eredmeny.Append(", ");
                }*/
                Console.WriteLine(szoveg);
            }
            //Console.WriteLine(eredmeny.ToString());
        }

        private static void feladat2()
        {
            double num01;
            double num02;

            Console.Write("\nInput a number: ");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            double result = num01 + num02;
            Console.WriteLine("\nThis result is: " + result);

            double result1 = num01 - num02;
            Console.WriteLine("This result is: " + result1);

            double result2 = num01 * num02;
            Console.WriteLine("This result is: " + result2);

            double result3 = num01 / num02;
            Console.WriteLine("This result is: " + result3);
        }

        private static void feladat1()
        {
            Console.WriteLine("First example?");
            Console.WriteLine("What is your name");

            string userName = Console.ReadLine();

            Console.WriteLine("\nHello " + userName + ", nice to meet you!");
        }
    }
}
