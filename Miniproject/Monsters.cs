public class Monster
{
    public int ID;
    public string name;
    public int damage;
    public int currenthp;
    public int maximumhp;

    public Monster(int monster_id, string Name, int monster_damage, int CurrentHP, int MaximumHP)
    {
        ID = monster_id;
        name = Name;
        damage = monster_damage;
        currenthp = CurrentHP;
        maximumhp = MaximumHP;
    }
    public void TakeDamage(int damage)
    {
        currenthp -= damage;
    }
}