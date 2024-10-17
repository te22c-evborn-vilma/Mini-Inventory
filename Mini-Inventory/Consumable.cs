public class Consumable : Item
{
    public int UsesMax;
    public int UsesCurrent;

    static void Use(Character target)
    {
        if (UsesCurrent < UsesMax)
        {
            Character.Hp += 10;
            UsesCurrent++;
        }
    }
}
