using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
   class Thief : Character
    {
        public Thief(string name, int hp, int damage, int dodgeRate, string item)
            : base(name, hp, damage, item)
        {
            DodgeRate = dodgeRate;
        }

        public void ShowStats()
        {
            Console.WriteLine($"{Name} => HP= {HP}, Dmg= {Damage}, DodgeRate= {DodgeRate}%, Item= {Item}");
        }
    }
}
