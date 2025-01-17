using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClasses
{
    class Wizard
    {
        public string name;
        public string favoriteSpell;
        public int spellSlots;
        public float experoence;        
        public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            experoence = 0f;
        }
        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellSlots--;
            } else
                Console.WriteLine(name + "is out of spell slots");
        }
        public void Meditate()
        {
            Console.WriteLine(name + "meditates to regain spell slots");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Spell slots: " + wizard.spellSlots);
            //wizard.Meditate();            
            Wizard wizard = new Wizard("Parry Hopper", "Unexpecto Patronum");
            wizard.CastSpell();

            Wizard wizard2 = new Wizard("Glindalf Merlinson", "Abracadabra");
            wizard2.CastSpell();


            //Console.WriteLine("Experience: " + wizard.experoence);

            // Wait before closing
            Console.ReadLine();
        }
    }
}
