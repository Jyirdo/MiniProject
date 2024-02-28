using System;
using System.ComponentModel.DataAnnotations;

class Player
{
    public string name;
    public int weapon;
    public int location;
    public int currenthp;
    public int maximumhp;
    public List<string> inventory;
    public int potion;
    public int damage;

    public Player(string Name, int CurrentWeapon, int CurrentLocation, int CurrentHP, int MaximumHP, int Damage)
    {
        this.name = Name;
        this.weapon = CurrentWeapon;
        this.location = CurrentLocation;
        this.currenthp = CurrentHP;
        this.maximumhp = MaximumHP;
        this.damage = Damage;
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
    public void TakeDamage(int damage)
    {
        currenthp -= damage;
    }
}