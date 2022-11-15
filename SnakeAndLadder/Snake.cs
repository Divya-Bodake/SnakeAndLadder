using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Snake
    {
        private object random;

        //public int initialPosition = 0; //UC1

        public void DiceRoll() //UC2
        {
            Random random = new Random();
            int Dicecount = random.Next(1, 7);
            Console.WriteLine("Dice Count is:" + Dicecount);
        }


    }
}
