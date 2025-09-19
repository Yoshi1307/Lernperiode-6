using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Healer : Character
    {
        public Healer(string name, int hp, int damage, int healPerRound, string item)
            : base(name, hp, damage, item)
        {
            HealPerRound = healPerRound;
        }
        public void ShowStats()
        {
            Console.WriteLine($"{Name} => HP= {HP}, Dmg= {Damage}, HealPerRound= {HealPerRound}, Item= {Item}");
        }
    }
}
