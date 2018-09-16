using HungerGames.Controller;
using HungerGames.Model;
using System;
using System.Collections.Generic;

namespace HungerGames
{
    class Program
    {
        static void Main(string[] args)
        {

        new ArenaController().start();

            // DateTime localDate = DateTime.Now;
            // Console.WriteLine("\n" + localDate + "\n" + "It is a new day... ");
            // Console.ReadLine();

            // int min = 1, max = 24;
            // Random RandomNumber = new Random();

            // int minAttack = 0, maxAttack = 10;
            // Random attackLevels = new Random();

            // int minDefense = 0, maxDefense = 10;
            // Random defenseLevels = new Random();

            // int minHealth = 0, maxHealth = 10;
            // Random healthLevels = new Random();

            // int minChange = 0, maxChance = 1;
            // Random changeLevels = new Random();

            // for (var person = 1; person < 25; person++)
            //      {
            //            Console.WriteLine("There will start a new fight with person " + RandomNumber.Next(min, max) + " and " + RandomNumber.Next(min, max) + ".");
            //            Console.ReadLine();

            //     while (attackLevels.Next(min, max) > defenseLevels.Next(min, max) || changeLevels.Next(min, max) > 0 || healthLevels.Next(min, max) > defenseLevels.Next(min, max))
            //     {
            //         if (attackLevels.Next(min, max) > defenseLevels.Next(min, max))
            //         {
            //             Console.WriteLine("You won because your attacklevel is " + attackLevels.Next(min, max));
            //             Console.ReadLine();
            //         }
            //         else if (changeLevels.Next(min, max) > 0)
            //         {
            //             Console.WriteLine("You won because your changelevel is 1 ");
            //             Console.ReadLine();
            //         }

            //         else if (healthLevels.Next(min, max) > defenseLevels.Next(min, max))
            //         {

            //             Console.WriteLine("You won because your healthLevel is " + healthLevels.Next(min, max));
            //             Console.ReadLine();
            //         }
                    
            //         break;
            //     }
         
            //     Console.WriteLine("End of the day");
            //     Console.WriteLine("=====================================");
            //     Console.ReadLine();

            // }
        }
    }
}