public class Inventory
{
    List<Item> Items = new();

    int length = Items.Count;
    static void Display()
    {
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"{i + 1}) {Items[i]}");
        }
    } 
}
