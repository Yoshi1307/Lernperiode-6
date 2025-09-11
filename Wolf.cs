using System.Xml.Linq;
using Text_RPG;
using static System.Net.Mime.MediaTypeNames;

class Wolf : Enemy
{
    public Wolf(int hp = 15, int damage = 7)
        : base("Wolf", hp, damage)
    {
    }

    public Wolf NextWolf()
    {
        return new Wolf(HP + 3, Damage + 5);
    }

    public override void ShowStats()
    {
        Console.WriteLine($"{Name} => HP= {HP}, Dmg= {Damage}");
    }
}