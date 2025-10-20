using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Magician : Character
    {
        public Magician(string name, int hp, int damage, int freezeChance, int confusionChance, string item)
            : base(name, hp, damage, item)
        {
            FreezeChance = freezeChance;
            ConfusionChance = confusionChance;
        }
        public void ShowStats()
        {
            Console.Write($"{Name} => HP= {HP}, Dmg= {Damage}, ");

            if (FreezeChance > 0)
                Console.Write($"FreezeChance= {FreezeChance}%, ");
            if (ConfusionChance > 0)
                Console.Write($"ConfusionChance= {ConfusionChance}%, ");

            Console.WriteLine($"Item= {Item}");
        }

        public void Freeze()
        {
            Random rnd = new Random();

            if (rnd.Next(100) < 15)
            {
                //Freeze
            }
            else
            {
                //Kein Freeze
            }
        }

        public void Confusion()
        {
            Random rnd = new Random();

            if (rnd.Next(100) < 15)
            {
                //Freeze
            }
            else
            {
                //Kein Freeze
            }
        }
    }
}
