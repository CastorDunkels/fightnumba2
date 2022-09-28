using System;
fighta f1 = new fighta();
f1.sword = new weapon();

while (f1.hp >= 0)
{
    Console.Clear();
    Console.WriteLine($"Name:{f1.name} \nHealth:{f1.hp}\n");
    Console.WriteLine($"Weapon:{f1.sword.name} \nDurability:{f1.sword.durability}\n\n");
    Console.WriteLine("Choose what to do:\n(A): Attack your opponent.\n(B): Heal yourself.\n(C): Repair your weapon.");
    string action = Console.ReadLine();
    action = action.ToLower();

    if (action == "attack" || action == "a")
    {
        f1.sword.attack();
    }
    else if (action == "heal" || action == "h")
    {
        //heal function
    }
    else if (action == "repair" || action == "r")
    {
        //repair funciton
    }
    else
    {
        Console.WriteLine("You cannot choose to do nothing");
    }
    Console.ReadLine();
    

}

Console.ReadLine();
