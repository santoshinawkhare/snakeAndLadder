using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC5
    {
        public const int startPosition = 0;
        public const int endPosition = 100;
        public const int ladder = 2;
        public const int snake = 1;

        public void WinnigPosition()
        {
            int currentrPosition = startPosition;
            Console.WriteLine("Your Current Position is :" + currentrPosition);

            for (int noOfTimeDiceRoll = 1; currentrPosition >= 0; noOfTimeDiceRoll++)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 7);
                Console.WriteLine("Number got on Dice :" + randomNumber);
                int move = random.Next(0, 3);
                if ((currentrPosition + randomNumber) >= 100)
                {
                    currentrPosition -= randomNumber;
                }
                else if ((currentrPosition + randomNumber) == 100)
                {
                    int finalPosition = currentrPosition + randomNumber;
                    Console.WriteLine("Player has reached final position" + finalPosition);
                    Console.WriteLine("Won the game and game over");
                    break;
                }
                switch (move)
                {
                    case snake:
                        Console.WriteLine("Snake");
                        currentrPosition -= randomNumber;
                        if (currentrPosition < 0)
                        {
                            currentrPosition = startPosition;
                            Console.WriteLine("start the position of player :" + currentrPosition);
                        }
                        break;

                    case ladder:
                        Console.WriteLine("Ladder");
                        currentrPosition += randomNumber;
                        break;

                    default:
                        Console.WriteLine("No Play");
                        break;
                }
            }
        }
    }
}
