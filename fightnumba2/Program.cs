using System;
Fighta f1 = new Fighta("Los Pollos Hermanos", 30);
Fighta f2 = new Fighta("Los Culos Hermanos", 200);
f1.hands = new Weapon("hands", 0, 1, 4);
f1.sword = new Weapon("Moonlight", 10, 10, 30);
f2.sword = new Weapon("Longsword", 20, 2, 15);
f2.hands = new Weapon("hands", 0, 1, 4);
Random generator = new Random();

Boolean playing = true;
while (playing)
{

    Boolean repeat = true;
    while (repeat)
    {
        Console.Clear();
        Console.WriteLine($"Name:{f1.name}                                                     Enemy name:{f2.name}\n" +
        $"Health:{f1.hp}                                                                    Enemy health:{f2.hp}\n");
        if (f1.activeWeapon().durability == -1)
        {
            Console.WriteLine($"Weapon:{f1.activeWeapon().name}                                                                    Enemy sword:{f2.activeWeapon().name}\n" +
            $"Durability:{f1.activeWeapon().durability}                                                                    Enemy durability:{f2.activeWeapon().durability}\n\n");
        }
        else
        {
            Console.WriteLine($"Weapon:{f1.activeWeapon().name}\nDurability:{f1.activeWeapon().durability}\n\n");
        }
        Console.WriteLine("Choose what to do:\n(A): Attack your opponent.\n(B): Heal yourself.\n(C): Repair your weapon.");
        string action = Console.ReadLine();
        action = action!.ToLower();

        if (action == "attack" || action == "a")
        {
            Console.Clear();
            f1.attack(f2);
            repeat = false;
        }
        else if (action == "heal" || action == "h" || action == "b")
        {
            Console.Clear();
            f1.heal();
            Console.WriteLine($"Health:{f1.hp}\nYou healed {f1.healing}:hp");
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

    int enemyAction = generator.Next(0, 10);
    Console.WriteLine($"\n{enemyAction}");
    if (enemyAction == 1)
    {
        f2.sword.repair();
        Console.WriteLine($"{f2.name} repaired their weapon and got {f2.sword.fixing} durability back they now have {f2.activeWeapon().durability} durability");

    }
    else if (enemyAction == 2)  //fix enemy text 
    {
        f2.heal();
        Console.WriteLine($"{f2.name} healed ");
    }
    else
    {
        f2.attack(f1);
        Console.WriteLine($"You took {f2.takeDmg} dmg");

    }
    Console.WriteLine("Press any button to continue");
    Console.ReadKey();
    if (f1.hp <= 0)
    {
        f1.hp = 0;
        Console.WriteLine("You died");
        Console.ReadKey();
        playing = false;
    }
    else if (f2.hp <= 0)
    {
        f2.hp = 0;
        Console.WriteLine("You win");
        Console.ReadKey();
        playing = false;
    }

}

Console.ReadLine();
