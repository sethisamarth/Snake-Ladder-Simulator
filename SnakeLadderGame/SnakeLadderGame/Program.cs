using System;
using System.Collections.Generic;

namespace SnakeLadderGame
{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            int playerPos = 0;
            int totalTimesDiceRoll = 0;

            // running while loop till the player reaches at 100

            while (playerPos <= 100)
            {

                int diceRoll = random.Next(1, 7);
                Console.WriteLine("value of dice Roll is {0}", diceRoll);


                // Checking for a option 
                var list = new List<string> { "NoPlay", "Ladder", "Snake" };
                Console.WriteLine("options we have 0.Noplay,1.Ladder,2.snake");


                int optionCheck = random.Next(0, 3);
                Console.WriteLine("option we get is : {0}", optionCheck);

                // getting position
                if (list[optionCheck] == "Ladder")
                {
                    playerPos = playerPos + diceRoll;
                }

                else if (list[optionCheck] == "Snake")
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
                totalTimesDiceRoll++;
            }
            Console.WriteLine("Total no.  of times dice rolled is {0}", totalTimesDiceRoll);

        }
    }
}
                   
