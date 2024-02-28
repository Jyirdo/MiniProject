using System;
using System.ComponentModel.DataAnnotations;

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
        inventory.Remove(inventory[inventory.Count() - 1]);
        potion -= 1;
        inventory.Add($"{potion} potion");
        Console.WriteLine("You consumed a potion\n");
        return currenthp;
    }

    public void Inventory()
    {
        inventory.Add("map");
        inventory.Add("compass");
        inventory.Add($"{weapon}");
        inventory.Add($"{potion} potions");
    }
}