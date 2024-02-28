using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What will your name be?");
        string? name = Console.ReadLine();
        Player mc = new Player(name, World.WEAPON_ID_RUSTY_SWORD, World.LOCATION_ID_HOME, 10, 10, 4);
        mc.Inventory();

        while (mc.currenthp > 0)
        {
            Console.WriteLine("What would you like to do (Enter a Number)?");
            Console.WriteLine("1: See game stats");
            Console.WriteLine("2: Move");
            Console.WriteLine("3: Fight");
            Console.WriteLine("4: Quit");
            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine($"\nYour current weapon is the {World.WeaponByID(mc.weapon).name}");
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
                Console.WriteLine($"You are at: {World.LocationByID(mc.location).Name}. From here you can go:");

                //middle of the map
                if (mc.location == World.LOCATION_ID_TOWN_SQUARE)
                {
                    Console.WriteLine($"1: {World.LocationByID(World.LOCATION_ID_TOWN_SQUARE).LocationToNorth.Name}");
                    Console.WriteLine($"2: {World.LocationByID(World.LOCATION_ID_TOWN_SQUARE).LocationToEast.Name}");
                    Console.WriteLine($"3: {World.LocationByID(World.LOCATION_ID_TOWN_SQUARE).LocationToSouth.Name}");
                    Console.WriteLine($"4: {World.LocationByID(World.LOCATION_ID_TOWN_SQUARE).LocationToWest.Name}");
                    string choice4 = Console.ReadLine();
                    if (choice4 == "1") { mc.location = World.LOCATION_ID_ALCHEMIST_HUT; }
                    else if (choice4 == "2") { mc.location = World.LOCATION_ID_GUARD_POST; }
                    else if (choice4 == "3") { mc.location = World.LOCATION_ID_HOME; }
                    else if (choice4 == "4") { mc.location = World.LOCATION_ID_FARMHOUSE; }
                }

                //north directions
                else if (mc.location == World.LOCATION_ID_ALCHEMIST_HUT)
                {
                    Console.WriteLine($"1: {World.LocationByID(World.LOCATION_ID_ALCHEMIST_HUT).LocationToNorth.Name}");
                    Console.WriteLine($"2: {World.LocationByID(World.LOCATION_ID_ALCHEMIST_HUT).LocationToSouth.Name}");
                    string choice4 = Console.ReadLine();
                    if (choice4 == "1") { mc.location = World.LOCATION_ID_ALCHEMISTS_GARDEN; }
                    else if (choice4 == "2") { mc.location = World.LOCATION_ID_TOWN_SQUARE; }
                }
                else if (mc.location == World.LOCATION_ID_ALCHEMISTS_GARDEN)
                {
                    Console.WriteLine($"1: {World.LocationByID(World.LOCATION_ID_ALCHEMISTS_GARDEN).LocationToSouth.Name}");
                    string choice4 = Console.ReadLine();
                    if (choice4 == "1") { mc.location = World.LOCATION_ID_ALCHEMIST_HUT; }
                }
                //east directions
                else if (mc.location == World.LOCATION_ID_GUARD_POST)
                {
                    Console.WriteLine($"1: {World.LocationByID(World.LOCATION_ID_GUARD_POST).LocationToEast.Name}");
                    Console.WriteLine($"2: {World.LocationByID(World.LOCATION_ID_GUARD_POST).LocationToWest.Name}");
                    string choice4 = Console.ReadLine();
                    if (choice4 == "1") { mc.location = World.LOCATION_ID_BRIDGE; }
                    else if (choice4 == "2") { mc.location = World.LOCATION_ID_TOWN_SQUARE; }
                }
                else if (mc.location == World.LOCATION_ID_BRIDGE)
                {
                    Console.WriteLine($"1: {World.LocationByID(World.LOCATION_ID_BRIDGE).LocationToEast.Name}");
                    Console.WriteLine($"2: {World.LocationByID(World.LOCATION_ID_BRIDGE).LocationToWest.Name}");
                    string choice4 = Console.ReadLine();
                    if (choice4 == "1") { mc.location = World.LOCATION_ID_SPIDER_FIELD; }
                    else if (choice4 == "2") { mc.location = World.LOCATION_ID_GUARD_POST; }
                }
                else if (mc.location == World.LOCATION_ID_SPIDER_FIELD)
                {
                    Console.WriteLine($"1: {World.LocationByID(World.LOCATION_ID_SPIDER_FIELD).LocationToWest.Name}");
                    string choice4 = Console.ReadLine();
                    if (choice4 == "1") { mc.location = World.LOCATION_ID_BRIDGE; }
                }

                //south directions
                else if (mc.location == World.LOCATION_ID_HOME)
                {
                    Console.WriteLine($"1: {World.LocationByID(World.LOCATION_ID_HOME).LocationToNorth.Name}");
                    string choice4 = Console.ReadLine();
                    if (choice4 == "1") { mc.location = World.LOCATION_ID_TOWN_SQUARE; }
                }

                //west directions
                else if (mc.location == World.LOCATION_ID_FARMHOUSE)
                {
                    Console.WriteLine($"1: {World.LocationByID(World.LOCATION_ID_FARMHOUSE).LocationToEast.Name}");
                    Console.WriteLine($"2: {World.LocationByID(World.LOCATION_ID_FARMHOUSE).LocationToWest.Name}");
                    string choice4 = Console.ReadLine();
                    if (choice4 == "1") { mc.location = World.LOCATION_ID_TOWN_SQUARE; }
                    else if (choice4 == "2") { mc.location = World.LOCATION_ID_FARM_FIELD; }
                }
                else if (mc.location == World.LOCATION_ID_FARM_FIELD)
                {
                    Console.WriteLine($"1: {World.LocationByID(World.LOCATION_ID_FARM_FIELD).LocationToWest.Name}");
                    string choice4 = Console.ReadLine();
                    if (choice4 == "1") { mc.location = World.LOCATION_ID_FARMHOUSE; }
                }
            }
            else if (choice == "3")
            {
                Fight();
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
        void Fight()
        {
            Monster monster = new Monster(1, "Goblin", 3, 9, 9);

            Console.WriteLine("Een wilde " + monster.name + " komt tevoorschijn!");

            while (mc.currenthp > 0 && monster.currenthp > 0)
            {
                monster.TakeDamage(mc.damage);
                Console.WriteLine("You hit the" + monster.name + "for" + mc.damage + " damage.");

                // Check if the monster is defeated
                if (monster.currenthp <= 0)
                {
                    Console.WriteLine("You defeated the " + monster.name + "!");
                    break;
                }

                // Monster attacks the player
                mc.TakeDamage(monster.damage);
                Console.WriteLine("The " + monster.name + " hits you for " + monster.damage + " damage.");

                // Check if the player is defeated
                if (mc.currenthp <= 0)
                {
                    Console.WriteLine("You were defeated by the " + monster.name + "...");
                    break;
                }

                Console.WriteLine("Your HP: " + mc.currenthp);
                Console.WriteLine(monster.name + "'s HP: " + monster.currenthp);
            }
        }
    }
}