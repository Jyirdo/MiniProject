class Player
{
    public string name;
    public string weapon;
    public string location;
    public int currenthp;
    public int maximumhp;

    public Player(string Name, string CurrentWeapon, string CurrentLocation, int CurrentHP, int MaximumHP)
    {
        name = Name;
        weapon = CurrentWeapon;
        location = CurrentLocation;
        currenthp = CurrentHP;
        maximumhp = MaximumHP;
    }
}