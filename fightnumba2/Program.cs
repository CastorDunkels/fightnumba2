using System;
fighta f1 = new fighta();
f1.sword = new weapon();

while (f1.hp >= 0)
{
    Console.Clear();
    Console.WriteLine($"Name:{f1.name} \nHealth:{f1.hp}\n");
    if (f1.sword.durability == -1){
        Console.WriteLine($"Weapon:{f1.sword.hands}\nDurability:{f1.sword.broken}\n\n");
    }
    else{
    Console.WriteLine($"Weapon:{f1.sword.name}\nDurability:{f1.sword.durability}\n\n");
    }
    Console.WriteLine("Choose what to do:\n(A): Attack your opponent.\n(B): Heal yourself.\n(C): Repair your weapon.");
    string action = Console.ReadLine();
    action = action.ToLower();

    if (action == "attack" || action == "a")
    {
        Console.Clear();
        f1.sword.attack();
        Console.WriteLine("Press any button to continue");
    }
    else if (action == "heal" || action == "h" || action == "b")
    {
        Console.Clear();
        f1.heal();
        Console.WriteLine("Press any button to continue");
    }
    else if (action == "repair" || action == "r" || action == "c")
    {
        Console.Clear();
        f1.sword.repair();
        Console.WriteLine("Press any button to continue");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("You cannot choose to do nothing\nPress any button to continue");
    }
    Console.ReadKey();
    

}

Console.ReadLine();
