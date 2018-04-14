using System;
using System.Collections.Generic;

namespace wns
{
    public class Wizard : Human
    {

        public Wizard(string n): base(n)
        {
            health = 50;
            intelligence = 25;
        }

        public void Heal()
        {
            this.intelligence *= 10;
        }


        public void Fireball(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                Random rand = new Random();
                enemy.health -= rand.Next(20,50);
            }
        }
    }
}