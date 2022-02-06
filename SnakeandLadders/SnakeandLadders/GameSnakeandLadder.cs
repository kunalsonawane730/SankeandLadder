using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadders
{
    public class SnakeandLadder
    {
    //UC-1
        public void GameSnakeandLadder()
        {
            int startPosition = 0;
            int positionPlyaer1;
            Console.WriteLine("Game is start");
            Console.WriteLine("Player1 start position is " + startPosition);
    //UC-2
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            Console.WriteLine("Rolled dice number is: " + diceNumber);

        }
    }
}
