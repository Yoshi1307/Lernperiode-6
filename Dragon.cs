
using System.Xml.Linq;
using Text_RPG;
using static System.Net.Mime.MediaTypeNames;

class Dragon : Enemy
{
    public int FlameDamage { get; set; }

    public Dragon(int hp = 100, int damage = 30, int flameDamage = 5)
        : base("Drache", hp, damage)
    {
        FlameDamage = flameDamage;
    }

    public Dragon NextDragon()
    {
        return new Dragon(HP * 2, Damage * 2, FlameDamage * 2);
    }

    public override void ShowStats()
    {
        Console.WriteLine($"{Name} => HP= {HP}, Dmg= {Damage}, FlameDmg= {FlameDamage} (erscheint nur alle 15 Runden)");
    }
}
