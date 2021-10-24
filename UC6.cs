using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC6
    {
        public const int startPosition = 0;
        public const int endPosition = 100;
        public const int ladder = 2;
        public const int snake = 1;

        public void RollDie()
        {
            //int dieCount = 0;
            int dieCount = 0;
            int playerPosition = startPosition;

            while (playerPosition <= endPosition)
            {
                dieCount++;
                Random random = new Random();
                int rollCheck = random.Next(1, 7);
                Console.WriteLine("Number got on Roll # " + dieCount + " is : " + rollCheck);
                int gameCheck = random.Next(0, 2);
                if ((playerPosition + rollCheck) > 100)
                {
                    playerPosition -= rollCheck;
                }
                else if ((playerPosition + rollCheck) == 100)
                {
                    int FinalPosition = playerPosition + rollCheck;
                    Console.WriteLine("Player has reached final position : " + FinalPosition);
                    Console.WriteLine("Player won the game");
                    break;
                }
                switch (gameCheck)
                {
                    case ladder:

                        playerPosition += rollCheck;
                        Console.WriteLine("Player Ladder Position is: " + playerPosition);
                        break;
                    case snake:
                        playerPosition -= rollCheck;
                        Console.WriteLine("Player Snake Position is: " + playerPosition);
                        if (playerPosition < 0)
                        {
                            playerPosition = startPosition;
                            Console.WriteLine("Player Start Position is: " + playerPosition);

                        }
                        break;
                    default:
                        Console.WriteLine("I will stay in same position");
                        break;
                }
            }
            Console.WriteLine("Number of times die rolled to reach final position is: " + dieCount);
        }
    }   
    }

