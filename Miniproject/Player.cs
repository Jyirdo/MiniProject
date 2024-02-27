class Player
{
    public string Name;
    public string Weapon;
    public string Location;
    public int CurrentHP;
    public int MaximumHP;
    public List<string> Inventory;

    public Player(string name, string currentWeapon, string currentLocation, int currentHP, int maximumHP, List<string> inventory)
    {
        Name = name;
        Weapon = currentWeapon;
        Location = currentLocation;
        CurrentHP = currentHP;
        MaximumHP = maximumHP;
        Inventory = inventory;
    }
}
