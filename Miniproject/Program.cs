class Program 
{
    public void Main()
    {
        Console.WriteLine("What will your name be?");
        string name = Console.ReadLine();
        Player mc = new Player(name, "bronze sword", "home", 10, 10);

        while (true)
        {
            Console.WriteLine("What would you like to do (Enter a Letter)?");
            Console.WriteLine("S: See game stats");
            Console.WriteLine("M: Move");
            Console.WriteLine("F: Fight");
            Console.WriteLine("Q: Quit");
            string? choice = Console.ReadLine();

            if (choice.ToUpper() == "S")
            {
                Console.WriteLine($"\nYour current weapon is the {mc.weapon}");
                Console.WriteLine($"You are at {mc.currenthp}/{mc.maximumhp}hp");
                Console.WriteLine("Press I to see inventory");
                string? choice2 = Console.ReadLine();
                if (choice2.ToUpper() = "I")
                {
                    // show weapons
                    // show healing potions
                    // show other items
                    Console.WriteLine("\nPress H to use a healing potion to regain 5hp");
                    string? choice3 = Console.ReadLine();
                    if (choice3.ToUpper() = "H")
                    {
                        mc.RegainHp();
                    }
                }
            }
            else if (choice.ToUpper() == "M")
            {
                Console.WriteLine("\nWhere would you like to go?");
                Console.WriteLine($"You are at: {mc.location}. From here you van go:");
                Console.WriteLine();
            }
            else if (choice.ToUpper() == "F")
            {
                // fight
            }
            else if (choice.ToUpper() == "Q")
            {
                break;
            }
            else
            {
                continue;
            }
        }
    }
}