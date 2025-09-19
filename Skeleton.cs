
using System.Xml.Linq;
using Text_RPG;
using static System.Net.Mime.MediaTypeNames;

class Skeleton : Enemy
{
    public string Weapon { get; set; }

    public Skeleton(int hp = 20, int damage = 5, string weapon = "Bogen")
        : base("Skelett", hp, damage)
    {
        Weapon = weapon;
    }

    public Skeleton NextSkeleton()
    {
        return new Skeleton(HP + 5, Damage + 3, Weapon);
    }

    public override void ShowStats()
    {
        Console.WriteLine($"\n{Name} => HP= {HP}, Dmg= {Damage}, Waffe= {Weapon}");
    }
}
