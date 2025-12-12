namespace GalacticQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Galactic Quest!");

            OpenMainMenu();
        }

        internal static void OpenMainMenu()
        {
            bool isAppRunning = true;

            while (isAppRunning)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Select your option and press Enter: \n 1.Travel \n 2.Journal \n 3.Exit \n");
                int.TryParse(Console.ReadLine(), out int readOption);


                switch (readOption)
                {
                    case (int)GameOptions.Monsters:
                        OpenTravelMenu();
                        break;

                    case (int)GameOptions.Journal:
                        OpenJournalMenu();
                        break;

                    case (int)GameOptions.Exit:
                        isAppRunning = false;
                        break;

                    default:
                        Console.WriteLine("-_-' Invalid Option");
                        break;

                }
            }
        }

        internal enum GameOptions
        {
            Monsters = 1,
            Journal = 2,
            Exit = 3
        }

        internal static void OpenTravelMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Select your option and press Enter: \n 1.Explore \n 2.Search For Items \n 3.Back To Ship \n 4.Back To Main Menu\n");

            int.TryParse(Console.ReadLine(), out int readOption);

            switch (readOption)
            {
                case 1:
                    Console.WriteLine("Selected Explore");
                    break;

                case 2:
                    Console.WriteLine("Selected Search For Items");
                    Weapon foundWeapon = new Weapon("Excalibur", 90);
                    Potion foundPotion = new Potion("Medkit", 75);
                    Console.WriteLine($"You found a {foundWeapon.Name} (Attack: {foundWeapon.AttackValue})");
                    Console.WriteLine($"You found a {foundPotion.Name} (Heal: {foundPotion.HealthValue})");
                    break;

                case 3:
                    Console.WriteLine("Selected Back To Ship");
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try a valid option.");
                    break;

            }
        }

        internal static void OpenJournalMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Select your option and press Enter: \n 1.Monsters \n 2.Planets \n 3.Items \n 4.Back To Main Menu\n");

            int.TryParse(Console.ReadLine(), out int readOption);

            switch (readOption)
            {
                case 1:
                    List<Monsters> monstersList = Monsters.GenerateMonsters();
                    ShowMonsters(monstersList);
                    break;

                case 2:
                    Console.WriteLine("Selected Planets");
                    break;

                case 3:
                    Console.WriteLine("Selected Items");
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try a valid option.");
                    break;
            }
        }
        internal static void ShowMonsters(List<Monsters> monsters)
        {
            Console.WriteLine("The monsters are : \n");

            foreach (Monsters m in monsters)
            {
                if (m is Clontobaur Clontobaur)
                {
                    Console.WriteLine($"Name: {m.Name} | HP: {m.Health} | Attack: {m.Attack} | Height: {Clontobaur.Height} ");
                }
                else if(m is Minotaur Minotaur){
                    Console.WriteLine($"Name: {m.Name} | HP: {m.Health} | Attack: {m.Attack} | Color: {Minotaur.Color}");
                         }
                else{
                    Console.WriteLine($"Name: {m.Name} | HP: {m.Health} | Attack: {m.Attack}");
                }
            }
            Console.WriteLine("\n");

            ShowMonstersOptions(monsters);
        }

        internal static void ShowMonstersOptions(List<Monsters> monsters)
        {
            Console.WriteLine("Press 1 to go back or 2 to filter monsters based on name");

            int.TryParse(Console.ReadLine(), out int userOption);
            switch (userOption)
            {
                case 1: break;
                case 2: FilterMonstersByName(monsters); break;
                default: Console.WriteLine("Invalid Option."); break;
            }
        }

        internal static void FilterMonstersByName(List<Monsters> monsters)
        {
            Console.WriteLine("Enter letters to filter monsters: ");
            string? userInput = Console.ReadLine();
            Console.WriteLine("\n");

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Showing all monsters.\n");
                foreach (var m in monsters) Console.WriteLine($"{m.Name} | HP: {m.Health}");
                return;
            }

            foreach (Monsters m in monsters)
            {
                if (m.Name.ToLower().Contains(userInput.ToLower()))
                {
                    Console.WriteLine($"Name: {m.Name} | HP: {m.Health} | ATT: {m.Attack}");
                }
            }
        }
    }
}