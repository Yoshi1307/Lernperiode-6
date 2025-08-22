namespace Text_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int HP = 0;
            int Dmg = 0;
            int Hpr = 0;

            Console.WriteLine("Hallo");
            Console.WriteLine("Willkommen im Text-RPG!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Wähle deine Klasse aus:");;
            Console.WriteLine("1. Dieb");
            Console.WriteLine("2. Magier");
            Console.WriteLine("3. Krieger");
            Console.WriteLine("4. Healer");

            Console.Write("Ihre Auswahl (1-4): ");
            string selection = Console.ReadLine();
            Console.Clear();

            if (selection == "1")
            {
                Console.WriteLine("Du hast den Dieb gewählt!");
                Console.WriteLine("1. Dylan    HP=90  Dmg=15  Dodgerate=30%   Items:Knüppel");
                Console.WriteLine("2. Jamal");

            }
            else if (selection == "2") 
            {
                Console.WriteLine("Du hast den Magier gewählt!");
                Console.WriteLine("1. Merlin");
                Console.WriteLine("2. Gandalf");
            }
            else if (selection == "3")
            {
                Console.WriteLine("Du hast den Krieger gewählt!");
                Console.WriteLine("1. Brutus");
                Console.WriteLine("2. Eberhard");
            }
            else if (selection == "4")
            {
                Console.WriteLine("Du hast den Healer gewählt!");
                Console.WriteLine("1. Benedikt");
                Console.WriteLine("2. Althea");
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl. Bitte wähle eine Zahl zwischen 1 und 4.");
            }
        }

        internal class Dieb
        {
            Dieb Dylan = new Dieb();
            Dieb Jamal = new Dieb();
        }
        internal class Magier
        {
            Magier Merlin = new Magier();
            Magier Gandalf = new Magier();
        }
        internal class Krieger
        {
            Krieger Brutus = new Krieger();
            Krieger Eberhard = new Krieger();
        }
        internal class Healer
        {
            Healer Benedikt = new Healer();
            Healer Althea = new Healer();
        }

    }
}
