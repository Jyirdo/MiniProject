public class Monster
{
    public int ID;
    public string name;
    public int damage;
    public int currenthp;
    public int maximumhp;

    public Monster(int monster_id, string monster_name, int monster_damage, int CurrentHP, int MaximumHP)
    {
        ID = monster_id;
        name = monster_name;
        damage = monster_damage;
        currenthp = CurrentHP;
        maximumhp = MaximumHP;
    }
}