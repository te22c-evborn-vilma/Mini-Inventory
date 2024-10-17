public class Consumable : Item
{
    public int UsesMax;
    public int UsesCurrent;

    public void Use(Character target)
    {
        if (UsesCurrent < UsesMax)
        {
            target.Hp += 10;
            UsesCurrent++;
        }
    }
}
