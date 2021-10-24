using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC3
    {
        public const int startPosition = 0;
        public const int endPosition = 100;
        public const int ladder = 2;
        public const int snake = 1;
        public void CheckOption()
        {
            int userPosition = startPosition;
             Console.WriteLine("Your Current Position is :" + userPosition);

            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            Console.WriteLine("Number got on Dice :" + randomNumber);

            int move = random.Next(0, 3);
            switch (move)
            {
                case snake:
                   Console.WriteLine("Snake");
                    userPosition -= randomNumber;
                    
                    break;

                case ladder:
                    Console.WriteLine("Ladder");
                    userPosition += randomNumber;
                    break;

                default:
                    Console.WriteLine("No Play");
                    break;
            }
            Console.WriteLine("Your Current Position is :" + userPosition);
        }
        
    }
}
