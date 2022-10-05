using System;
public class Fighta
{
    public string name;

    public int hp;

    public int healing;

    public Weapon sword;

    public Weapon hands; 

    public Fighta(string name, int hp){
        this.name = name;
        this.hp = hp;

    }

    public void takeDmg(int dmg){
        hp = hp - dmg;
    }

    public Weapon activeWeapon(){
        if(sword.durability > 0){
            return sword;
        }
        else
        {
            return hands;
        }
    }

    public void attack(Fighta person){
        activeWeapon().attack(person);
    }

    private Random generator = new Random();

    public void heal(){
        healing = generator.Next(5, 20);
        if(healing + hp > 50){
            healing = 50 - hp;
        }
        hp = hp + healing;
        if(hp > 50){
            hp = 50;
        }
        
    }
    
}
