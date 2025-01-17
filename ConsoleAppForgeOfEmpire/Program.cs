using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForgeOfEmpire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double szorzo = 1.9;
            for (int hely = 1; hely <= 5; hely++)
            {
                szamitas(hely, szorzo);
            }         
            Console.ReadLine();
        }

        private static void szamitas(int hely, double szorzo)
        {            
            Console.Write("1. billentyűzetett nyomod meg, akkor a saját nevid helyeit tudod kiszámolni \nés 3.és 4.megnyomássával tudod folytatni a kiszámolt őnerő. " + 
                "\n\n2. billentyűzetett nyomod meg, akkor az 1.9 nevifül vagy a villám 1.9 tudod kiszámolni." +
                "\n\n3. billenytűzetett nyomod meg, akkor meg az első pontból ki számolt helyeket tudod összeadni a parancsor megoldja. xd" +
                "\n\n4. billentyűzetett nyomod meg, akkor pedig a 3.-ból kiszámolt nevid helyeit \nösszeadot eredménnyét ki tudod számoltatni a nevi fp pontjából pl(6336 - 4903). \n\nÍrd be 1. - 4. mit szeretnél számolni stb: ");
            int beszam = Convert.ToInt32(Console.ReadLine());
            switch (beszam)
            {
                case 1:
                    Console.Write($"Írd be az {hely}. helyet (pl.: 1. hely, 2. hely, 3. hely, 4. hely, 5. hely): ");
                    if (int.TryParse(Console.ReadLine()?.Trim(), out int szam))
                    {
                        double eredmeny = szam * szorzo;
                        Console.WriteLine($"{hely}. hely eredménye: {eredmeny}\n");
                    }
                    else
                    {
                        Console.WriteLine("Hibás adatbevitel! Kérlek, egész számot adj meg.\n");
                    }
                    break;
                    
                case 2:
                    Console.Write($"Írd be az adot helyet amit viszel (fp * 1.9): ");
                    if (int.TryParse(Console.ReadLine(), out int szam1))
                    {
                        double eredmeny = szam1 * szorzo;
                        Console.WriteLine($"A hely eredménye: {eredmeny}\n");
                    }
                    else
                    {
                        Console.WriteLine("Hibás adatbevitel! Kérlek, egész számot adj meg.\n");
                    }
                    break;
                case 3:
                    Console.WriteLine("Írd be a saját nevidnek a ki számolt helyei ponjait és majd össze adódik (a kiszámolt nevid helyeit tudod ide írni 1. - 5. helyig). ");
                    Console.Write("\nElső hely: ");
                    int elso = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nMásodik hely: ");
                    int masodik = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nHarmadik hely: ");
                    int harmadik = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nNegyedik hely: ");
                    int negyedik = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nÖtödik hely: ");
                    int otodik = Convert.ToInt32(Console.ReadLine());
                    int vegsoeredmeny= elso + masodik + harmadik + negyedik + otodik;
                    Console.WriteLine($"\nA hely vegsőeredménye: {vegsoeredmeny}");
                    break;
                case 4:                    
                    Console.Write("Írt be a nevid fp pontyát amihez tudunk léptetni a kövi szintre  hely: ");
                    int fp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Írt be a 3. pontoból a kiszámolt eredményt: ");
                    int kiszamolt = Convert.ToInt32(Console.ReadLine());
                    int teljeseredmeny = fp - kiszamolt;
                    Console.WriteLine($"A hely vegsőeredménye: {teljeseredmeny}\n");
                    break;
                default: Console.WriteLine("Default"); break;
            }            
        }        
    }   
}
