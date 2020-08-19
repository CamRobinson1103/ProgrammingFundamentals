using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            Console.WriteLine("Hello, peasant. What dou art nameth?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " ! " + "Please input a role");
            string role = Console.ReadLine();
            //This variable is used to store health
            float health = 100.0f;
            //This value is used to heal player
            float healthRegen = 20;
            bool maxLevelReached = false;
            int maxLevel = 100;
            int level = 1;
            bool ready = true;
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine(health);
            //Create ann application that gets the user's name along with an addititonal input.
            //Print the user's name and input to the console along eith their stats.

            Console.WriteLine("Hi, low level player! State your name!");
            string protag = Console.ReadLine();
            Console.WriteLine("Well hi there " + protag + "!"  +  " Tell me your favorite weapon.");
            string weapon = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("Player Name: " + protag);
            Console.WriteLine("Player Weapon: " + weapon);
            Console.WriteLine("Ranger Color: " + color);
            int lv = 1;
            Console.WriteLine("Lv: " + lv);
            bool maxLevelReached2 = false;
            bool ready2 = true;
            float health2 = 50.0f;
            float health2Regen = 2;





            
        }
    }
}
