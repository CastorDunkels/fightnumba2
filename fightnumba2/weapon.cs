using System;

public class weapon
{
    public int dmg;

    public int maxAttack = 100;

    public int minAttack = 10;

    public int handDmg;

    public int handMinAttack = 1;

    public int handMaxAttack = 4;

    public int durability = 10;

    public int breaking;

    public int fixing;

    public string name = "Moonlight";

    public string hands = "Hands";

    public string broken = "None";

    private Random generator = new Random();


    public void attack()
    {
        if (durability > 0)
        {
            dmg = generator.Next(minAttack, maxAttack);
            Console.WriteLine($"You did {dmg}:dmg");
            breaking = generator.Next(1, 10);
            if (breaking > 1)
            {
                durability--;
                if(durability == 0){
                    Console.WriteLine("Your weapon broke");
                    durability = -1;
                }
                else{
                Console.WriteLine("Your weapons durability lessened");

                }

            }
            else
            {
                Console.WriteLine("Your attack was well placed which left your sword unscathed");
            }
        }
        else
        {
            handDmg = generator.Next(handMinAttack, handMaxAttack);
            Console.WriteLine($"You did {handDmg}:dmg");

        }
    }
    public void repair()
    {
        if (durability > 0)
        {
            fixing = generator.Next(1, 5);
            if (fixing + durability > 20){
                fixing = 20 - durability;
                durability = 20;
            }
            durability = durability + fixing;
            if(durability > 20){
                durability = 20;
            }
            Console.WriteLine($"Durability:{durability}\nYour weapon got {fixing} more durability");
        }
        else
        {
            Console.WriteLine("Your weapon is broken and cannot be fixed");
        }
    }

}
