using System;

namespace Text_RPG
{
    class Enemy
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Damage { get; set; }

        public Enemy(string name, int hp, int damage)
        {
            Name = name;
            HP = hp;
            Damage = damage;
        }

        public virtual void ShowStats()
        {
            Console.WriteLine($"{Name} => HP= {HP}, Dmg= {Damage}");
        }
    }
}