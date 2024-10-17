public class Weapon : Item
{
    public int MinDamage;
    public int MaxDamage;

    static int Attack()
    {
        return Random.Shared.Next(MinDamage, MaxDamage);
    }
}
