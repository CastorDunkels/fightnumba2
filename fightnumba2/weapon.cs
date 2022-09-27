using System;

public class weapon
{
    public int maxAttack = 100;
    public int minAttack = 10;

    public int handMinAttack = 1;
    public int handMaxAttack = 2;

    public int durability = 10;

    public int breaking;

    public string name = "Moonlight";

    private Random generator = new Random();

    
    public void attack(){
        if(durability > 0){

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
            generator.Next(handMinAttack, handMaxAttack);
            Console.WriteLine("Your hands hurt\n-1 Health");
            //hp--

        }
    }
    
}
