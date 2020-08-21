using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    { 
        public void Run()
        {//This variable is used to store health
            float health = 100.0f;
            //This value is used to heal player
            float healthRegen = 20;
            bool maxLevelReached = false;
            int damage = 20;
            int level = 1;
            bool ready = true;
            string role = "none";

            //This is the welcome message
            Console.WriteLine("Hello, peasant. What dou art nameth?");
            string name = Console.ReadLine();

            //This is the class selection
            Console.WriteLine("Welcome " + name + " ! " + "Please select a class");
            Console.WriteLine("Press 1 for Knight class");
            Console.WriteLine("Press 2 for Wizard class");
            char input = ' ';
            Console.WriteLine();
            while(input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    health = 200;
                    role = "Knight";
                }
                else if (input == '2')
                {
                    damage = 40;
                    role = "Wizard";
                }
                else
                Console.WriteLine("Invalid input. Using default stats");
            }
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Player MP: 100");
            Console.WriteLine(health);




            //Create ann application that gets the user's name along with an addititonal input.
            //Print the user's name and input to the console along With their stats.
            string color = "none";
            Console.WriteLine("Hi there fella! State your name!");
            string protag = Console.ReadLine();
            Console.WriteLine("Well hi there " + protag + "!"  +  " Tell me your favorite weapon.");
            string weapon = Console.ReadLine();
            int hit = 10;
            int def = 10;
            int spd = 10;
            int mp = 10;
            int hp = 10;

            //Picking your color
            Console.WriteLine("Pick one of these colors");
            Console.WriteLine("Press 1 for Red");
            Console.WriteLine("Press 2 for Blue");
            Console.WriteLine("Press 3 for Green");
            Console.WriteLine("Press 4 for Yellow");
            Console.WriteLine("Press 5 for Pink");
            char select = Console.ReadKey().KeyChar;

            if (select == '1')
            {
                hit = 20;
                def = 10;
                spd = 10;
                mp = 10;
                hp = 10;
                color = "Red";
            }
            else if (select == '2')
            {
                hit = 10;
                def = 20;
                spd = 10;
                mp = 10;
                hp = 10;
                color = "Blue";
            }
            else if (select == '3')
            {
                hit = 10;
                def = 10;
                spd = 20;
                mp = 10;
                hp = 10;
                color = "Green";
            }
            else if (select == '4')
            {
                hit = 10;
                def = 10;
                spd = 10;
                mp = 20;
                hp = 10;
                color = "Yellow";
            }
            else if (select == '5')
            {
                hit = 10;
                def = 10;
                spd = 10;
                mp = 10;
                hp = 20;
                color = "Pink";
            }

            Console.WriteLine("Player Name: " + protag);
            Console.WriteLine("Player Weapon: " + weapon);
            int lv = 1;
            Console.WriteLine("Lv: " + lv);
            bool maxLevelReached2 = false;
            bool ready2 = true;
            float health2 = 50.0f;
            float health2Regen = 2;

            Console.WriteLine("You have been selected for the Rescue Squadron! You have been asigned the color " + color +". " + "Welcome to have you along " + "! ");
            Console.WriteLine("Hopefully you have gotten your mutator. It may sound dangerous, but don't worry. This device will give you the power to save people! ");
            Console.WriteLine("With your special power of " + color + ", " + "you will be a massive asset to the team!");








            
        }
    }
}
