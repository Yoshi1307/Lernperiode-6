using System;
using System.Collections.Generic;
using System.Data;
using Text_RPG;

namespace Text_RPG
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Hallo");
            Console.WriteLine("Willkommen im Text-RPG!\n");

            Console.WriteLine("Wähle deine Klasse aus:");
            Console.WriteLine("1. Dieb");
            Console.WriteLine("2. Magier");
            Console.WriteLine("3. Krieger");
            Console.WriteLine("4. Healer");
            Console.Write("Ihre Auswahl (1-4): ");

            string selectionClass = Console.ReadLine();
            List<Character> characters = new List<Character>();
            Character selectedCharacter = null;

            switch (selectionClass)
            {
                case "1":
                    Console.WriteLine("\nDu hast den Dieb gewählt!");
                    characters.Add(new Thief("Dylan", 90, 15, 30, "Knüppel"));
                    characters.Add(new Thief("Jamal", 110, 10, 20, "Knüppel"));
                    break;
                case "2":
                    Console.WriteLine("\nDu hast den Magier gewählt!");
                    characters.Add(new Magician("Merlin", 100, 15, 15, 0, "Schneestab"));
                    characters.Add(new Magician("Gandalf", 95, 10, 0, 15, "Zauberstab"));
                    break;
                case "3":
                    Console.WriteLine("\nDu hast den Krieger gewählt!");
                    characters.Add(new Warrior("Brutus", 80, 30, 5, 0, "Zweihänderschwert"));
                    characters.Add(new Warrior("Eberhard", 85, 25, 0, 5, "Schwert und Schild"));
                    break;
                case "4":
                    Console.WriteLine("\nDu hast den Healer gewählt!");
                    characters.Add(new Healer("Benedikt", 130, 15, 2, "Lebensstab"));
                    characters.Add(new Healer("Althea", 150, 10, 3, "Lebensstab"));
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte wähle eine Zahl zwischen 1 und 4.");
                    return;
            }

            Console.WriteLine("\nWähle deinen Charakter:");
            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {characters[i].Name}");
                characters[i].ShowStats();
                /* if (characters[i] is Thief thief) thief.ShowStats();
                else if (characters[i] is Magician magician) magician.ShowStats();
                else if (characters[i] is Warrior warrior) warrior.ShowStats();
                else if (characters[i] is Healer healer) healer.ShowStats(); */
            }

            Console.Write("\nDeine Wahl (1-2): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                selectedCharacter = characters[0];
            }
            else if (choice == "2")
            {
                selectedCharacter = characters[1];
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl.");
                return;
            }

            Console.WriteLine("\nDeine Startwerte:");
            selectedCharacter.ShowStats();


            Random rnd = new Random();
            bool ausgeruht = false;
            int wave = 0;

            Goblin goblin = new Goblin();
            Skeleton skeleton = new Skeleton();
            Wolf wolf = new Wolf();
            Spider spider = new Spider();
            Dragon dragon = new Dragon();

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"\n--- Runde {wave + 1} ---");
                Console.WriteLine("Was möchtest du tun?");
                Console.WriteLine("1. Reisen");
                Console.WriteLine("2. Ausruhen");
                Console.Write("Deine Wahl: ");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    wave++;

                    Console.WriteLine($"\nDu gehst auf Reisen...");
                    ausgeruht = false;
                    Thread.Sleep(1000);

                    Enemy enemy;

                    if (wave % 15 == 0)
                    {
                        enemy = dragon;
                        dragon = dragon.NextDragon();
                    }
                    else
                    {
                        int choiceEnemy = rnd.Next(4);
                        switch (choiceEnemy)
                        {      
                            case 0:
                                enemy = goblin;
                                goblin = goblin.NextGoblin();
                                break;
                            case 1:
                                enemy = skeleton;
                                skeleton = skeleton.NextSkeleton();
                                break;
                            case 2:
                                enemy = wolf;
                                wolf = wolf.NextWolf();
                                break;
                            case 3:
                                enemy = spider;
                                spider = spider.NextSpider();
                                break;
                            default:
                                enemy = new Goblin();
                                break;
                        }
                    }

                   
                    Console.WriteLine($"\nEin {enemy.Name} erscheint!");
                    Thread.Sleep(1);
                    enemy.ShowStats();


                    int RandomStart = 0;
                    int zahl = rnd.Next(1, 3);

                    while (selectedCharacter.IsAlive && enemy.IsAlive)
                    {

                        while (RandomStart == 0)
                        {
                            RandomStart++;

                            Random RandomZahl = new Random();

                            if (zahl == 1)
                            {
                                do
                                {
                                    Console.WriteLine();
                                    Thread.Sleep(2000);
                                    while (!Console.KeyAvailable)
                                    {
                                        Console.Write("\rDrück eine Taste um anzugreifen      ");
                                        Thread.Sleep(300);
                                        Console.Write("\rDrück eine Taste um anzugreifen.     ");
                                        Thread.Sleep(300);
                                        Console.Write("\rDrück eine Taste um anzugreifen..    ");
                                        Thread.Sleep(300);
                                        Console.Write("\rDrück eine Taste um anzugreifen...   ");
                                        Thread.Sleep(300);
                                    }
                                    Console.WriteLine("\n\rDu greifst an!                       ");
                                    enemy.HP -= selectedCharacter.Damage;
                                    Thread.Sleep(500);
                                    Console.WriteLine($"\nDu hast dem Gegner {selectedCharacter.Damage} Schaden hinzugefügt");
                                    Thread.Sleep(1500);
                                    if (enemy.IsAlive)
                                    {
                                        Console.WriteLine($"Der Gegner hat noch {enemy.HP} HP");
                                    }
                                   

                                    Thread.Sleep(500);
                                    if (enemy.IsAlive)
                                    {
                                        Thread.Sleep(1000);
                                        Console.WriteLine("\nDu wirst angegriffen!");
                                        selectedCharacter.HP -= enemy.Damage;
                                        Thread.Sleep(500);
                                        Console.WriteLine($"\nDer Gegner hat dir {enemy.Damage} Schaden hinzugefügt");
                                        if (selectedCharacter.IsAlive)
                                        {
                                            Console.WriteLine($"Du hast noch {selectedCharacter.HP} HP");
                                        }
                                        
                                    }
                                }
                                while (selectedCharacter.IsAlive && enemy.IsAlive);

                                if (selectedCharacter.IsAlive)
                                {

                                    Console.WriteLine($"Du hast den {enemy.Name} besiegt!");
                                    Thread.Sleep (300);
                                    Console.WriteLine($"\nDu hast noch {selectedCharacter.HP} HP.");

                                }
                                else                                 
                                {
                                    Console.WriteLine("\nDu wurdest besiegt! Game Over.");
                                    return;
                                }




                            }
                            else if (zahl == 2)
                            {
                                do
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("\nDu wirst angegriffen!");
                                    selectedCharacter.HP -= enemy.Damage;
                                    Thread.Sleep(500);
                                    Console.WriteLine($"\nDer Gegner hat dir {enemy.Damage} Schaden hinzugefügt");
                                    Console.WriteLine($"Du hast noch {selectedCharacter.HP} HP");
                                    Console.WriteLine();
                                    if (selectedCharacter.IsAlive)
                                    {
                                        Thread.Sleep(1000);
                                        while (!Console.KeyAvailable)
                                        {
                                            Console.Write("\rDrück eine Taste um anzugreifen      ");
                                            Thread.Sleep(300);
                                            Console.Write("\rDrück eine Taste um anzugreifen.     ");
                                            Thread.Sleep(300);
                                            Console.Write("\rDrück eine Taste um anzugreifen..    ");
                                            Thread.Sleep(300);
                                            Console.Write("\rDrück eine Taste um anzugreifen...   ");
                                            Thread.Sleep(300);
                                        }
                                        Console.WriteLine("\n\rDu greifst an!                       ");
                                        enemy.HP -= selectedCharacter.Damage;
                                        Thread.Sleep(500);
                                        Console.WriteLine($"Du hast dem Gegner {selectedCharacter.Damage} Schaden hinzugefügt");
                                        Thread.Sleep(1500);
                                        if (enemy.IsAlive)
                                        {
                                            Console.WriteLine($"Der Gegner hat noch {enemy.HP} HP");
                                        }
                                        
                                    }
                                }
                                while (selectedCharacter.IsAlive && enemy.IsAlive);

                                if (selectedCharacter.IsAlive)
                                {
                                    Console.WriteLine($"Du hast den {enemy.Name} besiegt!");
                                    Thread.Sleep(300);
                                    Console.WriteLine($"\nDu hast noch {selectedCharacter.HP} HP.");

                                }
                                else
                                {
                                    Console.WriteLine("\nDu wurdest besiegt! Game Over.");
                                    return;
                                }


                            }
                        }
                    }
                }
                else if (action == "2")
                {
                    if (ausgeruht)
                    {
                        Console.WriteLine("Du kannst dich nur einmal ausruhen, bevor du wieder reisen musst!");
                    }
                    else
                    {
                        Console.WriteLine("\nDu ruhst dich aus. (+15 HP)");

                        for (int Countdown = 10; Countdown > 0; Countdown--)
                        {
                            Console.Write($"\rWartezeit: {Countdown} Sekunden ");
                            Thread.Sleep(1000);
                        }

                        Console.WriteLine("\nFertig ausgeruht!");
                        selectedCharacter.Heal(15);
                        ausgeruht = true;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, bitte wähle 1 oder 2.");
                }

                Thread.Sleep(1000);
                while (!Console.KeyAvailable)
                {
                    Console.Write("\rDrücke eine Taste, um fortzufahren      ");
                    Console.Write("\rDrück eine Taste um anzugreifen      ");
                    Thread.Sleep(300);
                    Console.Write("\rDrück eine Taste um anzugreifen.     ");
                    Thread.Sleep(300);
                    Console.Write("\rDrück eine Taste um anzugreifen..    ");
                    Thread.Sleep(300);
                    Console.Write("\rDrück eine Taste um anzugreifen...   ");
                    Thread.Sleep(300);
                }
            }
        }
    }
}

