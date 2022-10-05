using System.Reflection.Metadata.Ecma335;
using System;

public class Weapon
{

    public int maxAttack;

    public int minAttack;

    public int durability;

    public int breaking;

    public int fixing;
    
    public string name;

    public string broken = "None";

    public Weapon(string name, int durability, int minAttack, int maxAttack){
        this.name = name;
        this.durability = durability;
        this.minAttack = minAttack;
        this.maxAttack = maxAttack;
    }

    private Random generator = new Random();

    /*public int howMuchDmg(){
        return dmg;
    }*/


    public void attack(Fighta person)
    {
        int dmg = generator.Next(minAttack, maxAttack);
        person.takeDmg(dmg);
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
