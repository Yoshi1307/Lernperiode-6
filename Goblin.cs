
using System.Xml.Linq;
using Text_RPG;
using static System.Net.Mime.MediaTypeNames;

class Goblin : Enemy
{
    public string Weapon { get; set; }

    public Goblin(int hp = 10, int damage = 2, string weapon = "Dolch")
        : base("Goblin", hp, damage)
    {
        Weapon = weapon;
    }

    public Goblin NextGoblin()
    {
        return new Goblin(HP + 5, Damage + 2, Weapon);
    }

    public override void ShowStats()
    {
        Console.WriteLine($"{Name} => HP= {HP}, Dmg= {Damage}, Waffe= {Weapon}");
    }
}