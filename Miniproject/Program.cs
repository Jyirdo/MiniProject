class Program
{
    public static void Main()
    {
        Console.WriteLine("What will your name be?");
        string? name = Console.ReadLine();
        Player mc = new Player(name, "rusty sword", "home", 10, 10);
        mc.Inventory();

        while (mc.currenthp > 0)
        {
            Console.WriteLine("What would you like to do (Enter a Number)?");
            Console.WriteLine("1: See game stats");
            Console.WriteLine("2: Move");
            Console.WriteLine("3: Fight");
            Console.WriteLine("4: Quit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine($"\nYour current weapon is the {mc.weapon}");
                Console.WriteLine($"You are at {mc.currenthp}/{mc.maximumhp}hp");
                Console.WriteLine("Press I to see inventory");
                string? choice2 = Console.ReadLine();
                if (choice2.ToUpper() == "I")
                {
                    Console.WriteLine("\nYour inventory contains:");
                    for (int i = 0; i < mc.inventory.Count(); i++)
                    {
                        Console.WriteLine($"{mc.inventory[i]}");
                    }

                    Console.WriteLine("\nPress H to use a healing potion to regain 5hp");
                    string? choice3 = Console.ReadLine();
                    if (choice3.ToUpper() == "H")
                    {
                        mc.RegainHp();
                    }
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nWhere would you like to go?");
                Console.WriteLine($"You are at: {mc.location}. From here you can go:");
                
                if (mc.location == "home")
                {
                    Console.WriteLine($"N: {World.Locations}");
                    string direction = Console.ReadLine();
                }
            }
            else if (choice == "3")
            {
                // fight
            }
            else if (choice == "4")
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