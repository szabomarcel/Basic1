using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            feladat4();

            // Wait before closing
            Console.ReadKey();
        }

        private static void feladat4()
        {
            Console.WriteLine("How meny students are in your class: ");
            int studnetCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the names of the stundents: ");
            string[] students = new string[studnetCount];
            for (int i = 0; i < studnetCount; i++)
            {
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("--------------------");

            for (int i = 0; i < studnetCount; i++)
            {
                Console.WriteLine(students[i]);

            }
        }

        private static void feladat3()
        {
            List<string> shoppongList = new List<string>();
            {
                shoppongList.Add("Dreams");
                shoppongList.Add("Miracles");
                shoppongList.Add("Rainbows");
                shoppongList.Add("pony");

                for (int i = 0; i < shoppongList.Count; i++)
                {
                    Console.WriteLine(shoppongList[i]);
                }
                shoppongList.Remove("Dreams"); 
                shoppongList.RemoveAt(1);

                Console.WriteLine("--------------------");

            }
        }

        private static void feladat2()
        {
            string[] movieses = new string[4];
            Console.WriteLine("Type in for movies: ");

            for (int i = 0; i < movieses.Length; i++)
            {
                movieses[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere they ate alphabetically: ");

            Array.Sort(movieses);

            for (int i = 0; i <movieses.Length; i++)
            {
                Console.WriteLine(movieses[i]);

            }
        }

        private static void feladat1()
        {
            string[] movies = {"Lord of the Rings", "Fight Club", "Interestellar", "Gladiator" };
            for (int i = 0; i < movies.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + movies[i]);
            }
        }
    }
}
