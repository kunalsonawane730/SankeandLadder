using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadders
{
    public class SnakeandLadder
    {
        const int No_Play = 0; 
        const int Ladder = 1; 
        const int Snake = 2;
        const int FinalWinningPosition = 100;
        int PlayerPosition;
        //UC-1 start psition o
        public void GameSnakeandLadder()
        {
            int startPosition = 0;
            Console.WriteLine("Game is start");
            Console.WriteLine("Player start position is " + startPosition);

    //UC-2 Dice number result
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            Console.WriteLine("Rolled dice number is: " + diceNumber);

            //UC-3 Option for Player
            while (PlayerPosition < FinalWinningPosition)
            {
                int option = random.Next(0, 3);

                switch (option)
                {
                    case No_Play:
                        Console.WriteLine("No Play");
                        break;

                    case Ladder:
                        PlayerPosition += diceNumber;
                        Console.WriteLine("Ladder" + PlayerPosition);
                        break;

                    case Snake:
                        PlayerPosition -= diceNumber;
                        Console.WriteLine("Snake" + PlayerPosition);
                        if (PlayerPosition < 0)
                        {
                            PlayerPosition = 0;
                        }
                        break;
                }
                Console.WriteLine("Option is: " + option + "\nNow Player position is:" + PlayerPosition);
            }
        }
    }
}
