using System;

namespace ConsoleApp12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warrior thor = new Warrior("Thor", 100, 26, 10);
            MagicWarrior loki = new MagicWarrior("Loki", 75, 20, 10, 50);

            Battle.StartFight(thor, loki);


            /*
             Thor Attacks Hulk and Deals 74 Damage
             Maximus Has 69 Health

             Hulk Attacks Thor and Deals 6 Damage
             Maximus Has 21 Health

             Hulk Attacks Hulk and Deals 48 Damage
             Maximus Has 21 Health 

             Hulk Attacks Thor and Deals 48 Damage
             Bob Has -42 Health

             Thor has Died and Hulk is Victorious

             Game Over
            */
        }
    }
}