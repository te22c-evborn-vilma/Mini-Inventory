public class Character
{
    public int Hp;
    public string Name;
    public Inventory Backpack;

    public Character()
    {
        Hp = 80;
        Name = "X";

        Backpack = new();

        Weapon w = new()
        {
            Name = "Sword", 
            Weight = 10, 
            MinDamage = 10, 
            MaxDamage = 20
        };

        Consumable potion = new()
        {
            Name = "Healing potion", 
            Weight = 2, 
            UsesMax = 3, 
            UsesCurrent = 0
        };

        Backpack.Items.Add(w);
        Backpack.Items.Add(potion);
        
    }
}
