using System;

class Player
{
    public string name;
    public string weapon;
    public string location;
    public int currenthp;
    public int maximumhp;
    public List<string> inventory;
    public int potion;

    public Player(string Name, string CurrentWeapon, string CurrentLocation, int CurrentHP, int MaximumHP)
    {
        this.name = Name;
        this.weapon = CurrentWeapon;
        this.location = CurrentLocation;
        this.currenthp = CurrentHP;
        this.maximumhp = MaximumHP;
        inventory = new List<string>();
        potion = 1;
    }

    public int RegainHp()
    {
        currenthp += 5;
        if (currenthp > maximumhp)
        {
            currenthp = maximumhp;
        }
        potion -= 1;
        Console.WriteLine("You consumed a potion");
        return currenthp;
    }

    public void Inventory()
    {
        inventory.Add($"{weapon}");
        inventory.Add($"{potion} potion");
        inventory.Add("map");
        inventory.Add("compass");
    }
}