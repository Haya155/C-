using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    internal class HealthPotion : ICollectible
    {
        public string PotionName { get; set; }

        public HealthPotion(string p)
        {
            PotionName = p;
        }

        public void Collect()
        {
            Console.WriteLine("Health Potion collected!");
        }

        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = int.Parse(amountText);
                character.Heal(amount);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
        }
    }
}
