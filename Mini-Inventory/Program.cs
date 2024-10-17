Character newChar = new();

newChar.Backpack.Display();

Armor armor = new(){Name = "Helmet", Weight = 14f};

Console.WriteLine($"You found a(n) {armor.Name} on the ground. Would you like to pick it up? [ yes | no ]");

string answer = Console.ReadLine();

while (answer != "yes" && answer != "no")
{
    Console.WriteLine($"You found a(n) {armor.Name} on the ground. Would you like to pick it up? [ yes | no ]");
    answer = Console.ReadLine();
}

if (answer == "yes")
{
    newChar.Backpack.Items.Add(armor);
    Console.WriteLine("You put it in your backpack");
}
else
{
    Console.WriteLine($"You left the {armor.Name} on the ground");
}

Console.WriteLine("Now, you have this in your backpack");

newChar.Backpack.Display();

Console.ReadLine();