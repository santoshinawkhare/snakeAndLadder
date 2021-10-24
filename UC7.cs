using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC_7
    {
        public const int startPosition = 0;
        public const int endPosition = 100;
        public const int ladder = 2;
       // public const int snake = 1;
        private int PlayerOnePosition = 0;
        private int PlayerTwoPosition = 0;
        private bool PlayerOneDone = false;
        private bool PlayerTwoDone = false;
        private bool GameOver = false;
        public Random random = new Random();
        public void FinalPlay()
        {
            Console.WriteLine("Both  Players Starting Position From ZERO");
            int GameStart = random.Next(1, 3);
            switch (GameStart)
            {
                case 1:
                    Console.WriteLine("Player " + GameStart + " started the game");
                    RollDie1();
                    break;
                case 2:
                    Console.WriteLine("Player " + GameStart + " started the game");
                    RollDie2();
                    break;
            }
        }
        public void RollDie1()
        {
            while (!PlayerOneDone && !PlayerTwoDone)
            {
                Random random = new Random();
                int dieNumber = random.Next(1, 7);
                int gameCheck = random.Next(0, 2);

                if ((PlayerOnePosition + dieNumber) > 100)
                {
                    Console.WriteLine("Player 1 will stay in same position at " + PlayerOnePosition);
                    PlayerOnePosition -= dieNumber;
                }
                else if ((PlayerOnePosition + dieNumber) == endPosition)
                {
                    PlayerOneDone = (PlayerOnePosition + dieNumber) == endPosition;
                    GameOver = true;
                    Console.WriteLine("Player 1 has reached final position : " +endPosition);
                    Console.WriteLine("Player 1 won the game");
                    break;
                }
                else
                {
                    switch (gameCheck)
                    {
                        case ladder:
                            if (!PlayerOneDone)
                            {
                                Console.WriteLine("Player 1 Got Ladder ");
                                Console.WriteLine("Player 1 Die Value : " + dieNumber);
                                PlayerOnePosition += dieNumber;
                                Console.WriteLine("Player 1 Ladder Position after rolling " + dieNumber + " is " + PlayerOnePosition);
                                continue;
                            }
                            break;
                        default:
                            Console.WriteLine("Player 1 Got Snake ");
                            Console.WriteLine("Player 1 Die Value : " + dieNumber);
                            PlayerOnePosition -= dieNumber;
                            if (PlayerOnePosition <= 0)
                            {
                                PlayerOnePosition = startPosition;
                                PlayerOneDone = false;
                            }
                            Console.WriteLine("Player 1 Snake Position after rolling " + dieNumber + " is " + PlayerOnePosition);
                            if (GameOver == false)
                            {
                                Console.WriteLine("Player 2 Turn");
                                RollDie2();
                            }
                            break;
                    }
                }
            }
        }
        public void RollDie2()
        {
            while (!PlayerTwoDone && !PlayerOneDone)
            {
                Random random = new Random();
                int dieNumber = random.Next(1, 7);
                int gameCheck = random.Next(0, 2);

                if ((PlayerTwoPosition + dieNumber) > 100)
                {
                    Console.WriteLine("Player 2 will stay in same position at " + PlayerTwoPosition);
                    PlayerTwoPosition -= dieNumber;
                }
                else if ((PlayerTwoPosition + dieNumber) == endPosition)
                {
                    PlayerTwoDone = (PlayerTwoPosition + dieNumber) == endPosition;
                    GameOver = PlayerTwoDone;
                    Console.WriteLine("Player 2 has reached final position : " + endPosition);
                    Console.WriteLine("Player 2 won the game");
                    break;
                }
                else
                {
                    switch (gameCheck)
                    {
                        case ladder:
                            if (!PlayerTwoDone)
                            {
                                Console.WriteLine("Player 2 Got Ladder ");
                                Console.WriteLine("Player 2 Die Value : " + dieNumber);
                                PlayerTwoPosition += dieNumber;
                                Console.WriteLine("Player 2 Ladder Position after rolling " + dieNumber + " is " + PlayerTwoPosition);
                                continue;
                            }
                            break;
                        default:
                            Console.WriteLine("Player 2 Got Snake ");
                            Console.WriteLine("Player 2 Die Value : " + dieNumber);
                            PlayerTwoPosition -= dieNumber;
                            if (PlayerTwoPosition <= 0)
                            {
                                PlayerTwoPosition = startPosition;
                                PlayerTwoDone = false;
                            }
                            Console.WriteLine("A Player 2 Snake Position after rolling " + dieNumber + " is " + PlayerTwoPosition);
                            if (GameOver == false)
                            {
                                Console.WriteLine(" player 1 Turn");
                                RollDie1();
                            }
                            break;
                    }
                }
            }
        }
    }
}
