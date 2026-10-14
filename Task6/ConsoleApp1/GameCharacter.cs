using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal abstract class GameCharacter
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        protected int Health {  get; set; }
         public GameCharacter(string name ,int health)
        {
            _name = name;
            if (health < 0)
                Health = 0;
            else if (health > 100) 
                Health = 100;
            else
                Health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount) {
            if (amount <= 0)
            {
                Console.WriteLine("Damage should be positve");
                return;
            }
            Health = Health - amount;
            if (Health < 0)
                Health = 0;
            
  
        
        }

        



    }
}
