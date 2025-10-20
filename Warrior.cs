using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Warrior : Character
    {
        public Warrior(string name, int hp, int damage, int critChance, int damageReduction, string item)
            : base(name, hp, damage, item)
        {
            CritChance = critChance;
            DamageReduction = damageReduction;
        }

        public void ShowStats()
        {
            Console.Write($"{Name} => HP= {HP}, Dmg= {Damage}; ");
            if (CritChance > 0)
                Console.Write($"CritChance= {CritChance}%, ");
            if (CritChance == 0)
                Console.Write($"DmgReduction= {DamageReduction}%, ");
            Console.WriteLine ($"Item= {Item}");
        }

        public void Crit()
        { 
        
        }

        public void DmgReduction()
        {

        }
    }
}
