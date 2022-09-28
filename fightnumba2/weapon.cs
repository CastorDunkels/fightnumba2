using System;

public class weapon
{
    public int maxAttack = 100;

    public int minAttack = 10;

    public int handMinAttack = 1;

    public int handMaxAttack = 2;

    public int durability = 0;

    public int breaking;

    public string name;

    private Random generator = new Random();

    
    public void attack(){
        if(durability > 0){
            name = "Moonlight";
            generator.Next(minAttack,maxAttack);
            breaking = generator.Next(10);
            if(breaking > 1){
                durability --;
                Console.WriteLine("Your weapon took dmg");
            }
            else{
                Console.WriteLine("Your attack was well placed which left your sword unscathed");
            }
        }
        else{
            name = "Hands";
            generator.Next(handMinAttack, handMaxAttack);
        }
    }
    
}
