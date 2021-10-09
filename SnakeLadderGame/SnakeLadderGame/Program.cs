using System;
using System.Collections.Generic;

namespace SnakeLadderGame
{
    class Program
    {
       // public static string Ladder { get; private set; }
       // public static string Snake { get; private set; }

        static void Main(string[] args)
        {
            Random random = new Random();
            int playerPos = 0; 
           int diceRoll = random.Next(1, 7);
            Console.WriteLine("value of dice Roll is {0}", diceRoll);

            // Checking for a option 


            var list = new List<string> { "NoPlay", "Ladder", "Snake" };

            int optionCheck = random.Next(0,3);

            Console.WriteLine("options we have 0.Noplay,1.Ladder,2.snake");

            Console.WriteLine("option we get is : {0}", optionCheck);

            // getting position
            if (list[optionCheck] == "Ladder")
            {
                playerPos = playerPos+ diceRoll;
            }
            
            else if(list[optionCheck] == "Snake")
            {
                if (playerPos < diceRoll)
                {
                    playerPos = 0;
                }
                else
                {
                    playerPos = playerPos - diceRoll;

                }
                
            }

            Console.WriteLine("The player postion is : {0}", playerPos);
            
          
        }
    }
}
