using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    internal class Wizard : GameCharacter
    {
        public Wizard(string name, int health) : base(name, health) { }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");
        }

        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount);
            Console.WriteLine($"{Name} takes {amount} damage.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }
    }
}
