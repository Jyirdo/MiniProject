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

    public int RegainHp()
    {
        currenthp += 5;
        if (currenthp > maximumhp)
        {
            currenthp = maximumhp;
        }
        return currenthp;
    }
}