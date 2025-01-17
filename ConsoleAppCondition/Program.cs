using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCondition
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
            Console.Write("Input a number between 1 and 5: ");
            int num = Convert.ToInt32(Console.ReadLine());
            /*if(num == 1){
                Console.WriteLine("One");
            }else if(num == 2){
                Console.WriteLine("Two");
            }else if (num == 3){
                Console.WriteLine("Three");
            }else if(num == 4){
                Console.WriteLine("Four");
            }else if(num == 5){
                Console.WriteLine("Five");
            }*/
            switch(num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default: Console.WriteLine("Default"); break;
            }
        }

        public static void feladat2()
        {
            int age;
            int height;
            Console.Write("Please input age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please input height (cm): ");
            height = Convert.ToInt32(Console.ReadLine());
            /*if(age >= 18)
            {
                if(height > 160) 
                {
                    Console.WriteLine("You can enter");
                }
                else
                {
                    Console.WriteLine("Not don't meet the requintments");
                }
            }*/
            if(age >= 18 && height >= 160) 
                Console.WriteLine("You can enter");
            else
                Console.WriteLine("Not don't meet the requintments");
        }

        public static void feladat1()
        {
            Console.WriteLine("Welcome! Ticket are 5$. Plase insert cash");
            int cash = Convert.ToInt32(Console.ReadLine());
            if (cash < 5)
            {
                Console.WriteLine("That's not enough money");
            }
            else if (cash == 5)
            {
                Console.WriteLine("Here is your ticket.");
            }
            else
            {
                int change = cash - 5;
                Console.WriteLine("Here is oyur ticket and " + change + "$ in change");
            }

        }
    }
}
