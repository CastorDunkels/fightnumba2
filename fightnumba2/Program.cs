using System;
fighta f1 = new fighta();
fighta f2 = new fighta();
f1.sword = new weapon();
f2.sword = new weapon();
f2.hp = f1.hp * 10;
f2.sword.maxAttack = f1.sword.maxAttack / 2;
f2.sword.minAttack = f1.sword.minAttack / 5;
f2.sword.durability = f1.sword.durability + 10;
Random generator = new Random();

while (f1.hp >= 0 || f2.hp >= 0)
{

    Boolean repeat = true;
    while (repeat)
    {
        Console.Clear();
        Console.WriteLine($"Name:{f1.name}                                                     Enemy name:{f2.enemyName}\nHealth:{f1.hp}                                                                    Enemy health:{f2.hp}\n");
        if (f1.sword.durability == -1)
        {
            Console.WriteLine($"Weapon:{f1.sword.hands}                                                                    Enemy sword:{f2.sword.hands}\nDurability:{f1.sword.broken}                                                                    Enemy durability:{f2.sword.durability}\n\n");
        }
        else
        {
            Console.WriteLine($"Weapon:{f1.sword.name}\nDurability:{f1.sword.durability}\n\n");
        }
        Console.WriteLine("Choose what to do:\n(A): Attack your opponent.\n(B): Heal yourself.\n(C): Repair your weapon.");
        string action = Console.ReadLine();
        action = action.ToLower();

        if (action == "attack" || action == "a")
        {
            Console.Clear();
            f1.sword.attack();
            if(f1.sword.durability > 0){
            f2.hp = f2.hp - f1.sword.dmg; 
            }
            else{
                f2.hp = f2.hp - f1.sword.handDmg;
            }
            repeat = false;
        }
        else if (action == "heal" || action == "h" || action == "b")
        {
            Console.Clear();
            f1.heal();
            repeat = false;
        }
        else if (action == "repair" || action == "r" || action == "c")
        {
            Console.Clear();
            f1.sword.repair();
            repeat = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You cannot choose to do nothing\nPress any button to continue");
            Console.ReadKey();
            
        }
    }

    f2.enemyAction = generator.Next(0, 10);
    Console.WriteLine($"\n{f2.enemyAction}");
    if (f2.enemyAction == 1)
    {
        f2.sword.repair();

    }
    else if (f2.enemyAction == 2)
    {
        f2.heal();
    }
    else
    {
        f2.sword.attack();

    }
    Console.WriteLine("Press any button to continue");
    Console.ReadKey();


}

Console.ReadLine();
