using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    internal class Warrior : GameCharacter
    {
        public Warrior(string name, int health) : base(name, health) { }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }

        public override void TakeDamage(int amount)
        {
            int finalDamage = amount - 2; 
            if (finalDamage < 0) finalDamage = 0;

            base.TakeDamage(finalDamage);
            Console.WriteLine($"{Name} takes {finalDamage} damage.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }
    }
}