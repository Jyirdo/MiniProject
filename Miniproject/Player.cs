using System;

class Player
{
    public string name;
    public string weapon;
    public string location;
    public int currenthp;
    public int maximumhp;

    public Player(string Name, string CurrentWeapon, string CurrentLocation, int CurrentHP, int MaximumHP)
    {
        this.name = Name;
        this.weapon = CurrentWeapon;
        this.location = CurrentLocation;
        this.currenthp = CurrentHP;
        this.maximumhp = MaximumHP;
    }

    public static void Main()
    {
        Player ThePlayer = new Player("bob", "sword", "church", 10, 10);
        ThePlayer.RegainHp();
    }

    public int RegainHp()
    {
        string input = Console.ReadLine();
        if(input == "H")
        {
            currenthp += 5;
            if (currenthp > maximumhp)
            {
                currenthp = maximumhp;
            }
            return currenthp;
        }
        else
        {
            return currenthp;
        }
    }
}