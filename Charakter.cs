using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Character
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Damage { get; set; }
        public int HealPerRound { get; set; }
        public int DamageReduction { get; set; }
        public int CritChance { get; set; }
        public int DodgeRate { get; set; }
        public int ConfusionChance { get; set; }
        public int FreezeChance { get; set; }
        public string Item { get; set; }

        public int MaxHP { get; set; }

        public Character(string name, int hp, int damage, string item)
        {
            Name = name;
            HP = hp;
            Damage = damage;
            Item = item;
            MaxHP = hp;
        }

        public void Heal(int amount)
        {
            HP = Math.Min(HP + amount, MaxHP);
            Console.WriteLine($"Du wurdest geheilt! HP: {HP}/{MaxHP}");
        }
    }



}
