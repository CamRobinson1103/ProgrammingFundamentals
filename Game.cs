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
            string name2 = Console.ReadLine();
            Console.WriteLine("Well hi there " + name2 + "!"  +  " Tell me your favorite weapon.");
            string weapon = Console.ReadLine();
            Console.WriteLine("Player Name: " + name2);
            Console.WriteLine("Player Weapon: " + weapon);
            int level2 = 1;
            Console.WriteLine("Player level: " + level2);
            bool maxLevelReached2 = false;
            bool ready2 = true;




            
        }
    }
}
