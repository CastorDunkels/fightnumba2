using System;
public class fighta
{
    public string name = "Los Pollos Hermanos";
    public int hp = 20;

    public string enemyName = "Los Culos Hermanos";

    public int enemyAction;

    public int healing;

    public weapon sword;

    private Random generator = new Random();

    public void heal(){
        healing = generator.Next(1, 20);
        if(healing + hp > 50){
            healing = 50 - hp;
            hp = 50;
        }
        hp = hp + healing;
        if(hp > 50){
            hp = 50;
        }
        Console.WriteLine($"Health:{hp}\nYou healed {healing}:hp");
    }
    
}
