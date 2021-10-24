using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC4
    {
        public const int startPosition = 0;
        public const int endPosition = 100;
        public const int ladder = 2;
        public const int snake = 1;

        public void RepeatTillWin()
        {
            int currentrPosition = startPosition;
            for (int noOfTimeDiceRoll = 1; currentrPosition >= 0; noOfTimeDiceRoll++)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 7);
                int move = random.Next(0, 3);
                if (currentrPosition >= 100)
                {
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
            Console.WriteLine("The final play position is : " + currentrPosition);
        }
    
    }
}

