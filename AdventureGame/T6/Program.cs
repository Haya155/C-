using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ADVENTURE GAME =====");
            Console.WriteLine();

            Warrior w = new Warrior("Alex", 80);
            w.UseSpecialAbility();
            w.TakeDamage(10);

            Console.WriteLine();
            w.Heal();

            Console.WriteLine();
            w.Heal(15);

            Console.WriteLine();


            Wizard wi = new Wizard("Luna", 70);
            wi.UseSpecialAbility();
            wi.TakeDamage(10);

            Console.WriteLine();


            HealthPotion p = new HealthPotion("Health Potion");
            p.Collect();

            Console.WriteLine();
            p.Use(wi, "15");

            Console.WriteLine();
            p.Use(wi, "abc"); 



        }
    }
}
