
using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace T6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ADVENTURE GAME =====");
            Console.WriteLine();

            Warrior w = new Warrior("Alex", 80);
            Wizard wi = new Wizard("Luna", 70);

            List<GameCharacter> chars = new List<GameCharacter>();
            chars.Add(w);
            chars.Add(wi);

            foreach (GameCharacter chara in chars)
            {
                Console.WriteLine(chara.Name );
                chara.UseSpecialAbility();
            }

            Console.WriteLine();

            w.TakeDamage(10);
            wi.TakeDamage(10);

            Console.WriteLine("\n=== Character Health ===");
            Console.WriteLine(w.Name + ": " + w.CurrentHealth);
            Console.WriteLine(wi.Name + ": " + wi.CurrentHealth);

            Console.WriteLine("\n=== Healing ===");
            w.Heal();
            w.Heal(15);

            HealthPotion p = new HealthPotion("Health Potion");
            Console.WriteLine();
            p.Collect();

            Console.WriteLine();
            p.Use(wi, "15");

            Console.WriteLine();
            p.Use(wi, "abc");
        }
    }
}
