using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Snake
    {
        public int PlayerPosition = 0;
        public const int Noplay = 0, Ladder = 1, Snakee = 2;

        Random random = new Random();
        //public int initialPosition = 0; //UC1

        //public void DiceRoll() //UC2
        //{
        //    Random random = new Random();
        //    int Dicecount = random.Next(1, 7);
        //    Console.WriteLine("Dice Count is:" + Dicecount);
        //}

        public void CheckforOption() //UC3
        {
            int choice = random.Next(0, 3);
            switch (choice)
            {
                case Noplay:
                    PlayerPosition += 0;
                    Console.WriteLine("player is at same place");
                    break;
                case Ladder:
                    PlayerPosition += 0;
                    Console.WriteLine("player is at {0}", PlayerPosition);
                    break;
                case Snakee:
                    PlayerPosition -= 0;
                    Console.WriteLine("player is at {0}", PlayerPosition);
                    break;
                default:
                    Console.WriteLine("invalid data");
                    break;
            }


        }
    }
}
