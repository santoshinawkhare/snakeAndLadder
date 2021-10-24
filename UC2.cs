using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC2
    {
        public const int startPosition = 0;
        public const int endPosition = 100;
        public void RollDie()
        {
           /* int userPositon = startPosition;
            Console.WriteLine("Your Current Position is :" + userPositon);*/

            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            Console.WriteLine("Number got on Dice :" + randomNumber);
        }
    }
}
