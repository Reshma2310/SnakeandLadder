using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class SnakeAndLadder
    {
        int startPosition = 0, playerPosition = 0;
        Random random = new Random();
        public void diceRoll()
        {
            int diceNo = random.Next(1, 6);
        Console.WriteLine("Dice value of player is " + diceNo);
        }
    }
}
