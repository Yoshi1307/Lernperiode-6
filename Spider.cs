using System.Xml.Linq;
using Text_RPG;
using static System.Net.Mime.MediaTypeNames;

class Spider : Enemy
{
    public int PoisonDamage { get; set; }

    public Spider(int hp = 10, int damage = 2, int poisonDamage = 1)
        : base("Spinne", hp, damage)
    {
        PoisonDamage = poisonDamage;
    }

    public Spider NextSpider()
    {
        return new Spider(HP + 5, Damage + 2, PoisonDamage + 1);
    }

    public override void ShowStats()
    {
        Console.WriteLine($"{Name} => HP= {HP}, Dmg= {Damage}, PoisonDmg= {PoisonDamage}");
    }
}
