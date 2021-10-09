using System;

namespace SnakeLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerPos = 0; //diceRoll;
           int diceRoll = random.Next(1, 7);
            Console.WriteLine("value of dice Roll is {0}", diceRoll);
          
        }
    }
}
