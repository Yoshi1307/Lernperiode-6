namespace Text_RPG
{

    using System;

    class Program
    {
        static void Main()
        {
            int HP = 0;
            int Dmg = 0;
            int Hpr = 0;
            int DmgReduction = 0;
            int critChance = 0;
            string Items = "";
            int Dodgerate = 0;
            int confusionChance = 0;
            int freezeChance = 0;

            Console.WriteLine("Hallo");
            Console.WriteLine("Willkommen im Text-RPG!");
            Console.WriteLine();
            Console.WriteLine("Wähle deine Klasse aus:");
            Console.WriteLine("1. Dieb");
            Console.WriteLine("2. Magier");
            Console.WriteLine("3. Krieger");
            Console.WriteLine("4. Healer");

            Console.Write("Ihre Auswahl (1-4): ");
            string selectionClass = Console.ReadLine();


            if (selectionClass == "1")
            {
                Console.WriteLine("Du hast den Dieb gewählt!");
                Console.WriteLine("1. Dylan    HP=90  Dmg=15  Dodgerate=30%   Items: Knüppel");
                Console.WriteLine("2. Jamal    HP=110 Dmg=10  Dodgerate=20%   Items: Knüppel");

                Console.Write("Wähle deinen Charakter (1-2): ");
                string thiefChoice = Console.ReadLine();

                if (thiefChoice == "1")
                {
                    HP = 90;
                    Dmg = 15;
                    Dodgerate = 30;
                    Items = "Knüppel";
                    Console.WriteLine("Du spielst jetzt Dylan!");
                }
                else if (thiefChoice == "2")
                {
                    HP = 110;
                    Dmg = 10;
                    Dodgerate = 20;
                    Items = "Knüppel";
                    Console.WriteLine("Du spielst jetzt Jamal!");
                }
            }
            else if (selectionClass == "2")
            {
                Console.WriteLine("Du hast den Magier gewählt!");
                Console.WriteLine("1. Merlin    HP=100  Dmg=15  Freezechance=15%     Items: Schneestab");
                Console.WriteLine("2. Gandalf   HP=95   Dmg=10  Confusionchance=15%  Items: Zauberstab");

                Console.Write("Wähle deinen Charakter (1-2): ");
                string magicianChoice = Console.ReadLine();

                if (magicianChoice == "1")
                {
                    HP = 100;
                    Dmg = 15;
                    freezeChance = 15;
                    Items = "Schneestab";
                    Console.WriteLine("Du spielst jetzt Merlin!");
                }
                else if (magicianChoice == "2")
                {
                    HP = 95;
                    Dmg = 10;
                    confusionChance = 15;
                    Items = "Zauberstab";
                    Console.WriteLine("Du spielst jetzt Gandalf!");
                }
            }
            else if (selectionClass == "3")
            {
                Console.WriteLine("Du hast den Krieger gewählt!");
                Console.WriteLine("1. Brutus    HP=80  Dmg=30  Critchance=5%             Items: Zweihänderschwert");
                Console.WriteLine("2. Eberhard  HP=85  Dmg=25  Damagereduction=5%        Items: Schwert und Schild");

                Console.Write("Wähle deinen Charakter (1-2): ");
                string warriorChoice = Console.ReadLine();

                if (warriorChoice == "1")
                {
                    HP = 80;
                    Dmg = 30;
                    critChance = 5;
                    Items = "Zweihänderschwert";
                    Console.WriteLine("Du spielst jetzt Brutus!");
                }
                else if (warriorChoice == "2")
                {
                    HP = 85;
                    Dmg = 25;
                    DmgReduction = 5;
                    Items = "Schwert und Schild";
                    Console.WriteLine("Du spielst jetzt Eberhard!");
                }
            }
            else if (selectionClass == "4")
            {
                Console.WriteLine("Du hast den Healer gewählt!");
                Console.WriteLine("1. Benedikt   HP=130  Dmg=15  HealPerRound=2   Items: Lebensstab");
                Console.WriteLine("2. Althea     HP=150  Dmg=10  HealPerRound=3   Items: Lebensstab");

                Console.Write("Wähle deinen Charakter (1-2): ");
                string healerChoice = Console.ReadLine();

                if (healerChoice == "1")
                {
                    HP = 130;
                    Dmg = 15;
                    Hpr = 2;
                    Items = "Lebensstab";
                    Console.WriteLine("Du spielst jetzt Benedikt!");
                }
                else if (healerChoice == "2")
                {
                    HP = 150;
                    Dmg = 10;
                    Hpr = 3;
                    Items = "Lebensstab";
                    Console.WriteLine("Du spielst jetzt Althea!");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl. Bitte wähle eine Zahl zwischen 1 und 4.");
            }

            Console.WriteLine();
            Console.WriteLine($"Deine Startwerte: HP={HP}, Dmg={Dmg}, HealPerRound={Hpr}, DmgReduction={DmgReduction}, CritChance={critChance} Dodgerate={Dodgerate}, ConfusionChance={confusionChance}, FreezeChance={freezeChance}, Items={Items}");
        }
    }
}
