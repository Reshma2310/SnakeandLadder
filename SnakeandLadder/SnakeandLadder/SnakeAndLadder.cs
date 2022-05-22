using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class SnakeAndLadder
    {
        public int diceNo, diceRollTimes = 0, player1Position = 0, player2Position = 0,player1,player2;
        const int noPlay = 0, snake = 1, ladder = 2;
        Random random = new Random();
        public void DiceRollGame()
        {
            while (player1Position != 100 && player2Position != 100)
            {
                player1= random.Next(1, 7);
                player2= random.Next(1, 7);                
                diceRollTimes++;
                repeat1:
                int value1 = random.Next(0, 3);
                switch (value1)
                {
                    case noPlay:
                        player1Position += 0;                        
                        break;
                    case snake:
                        player1Position -= player1;
                        break;
                    case ladder:
                        player1Position += player2;
                        break;
                    default:
                        break;
                }
                if (player1Position < 0)
                    player1Position = 0;                
                if (player1Position > 100)                
                    player1Position -= player1;      
                repeat2:
                int value2 = random.Next(0, 3);
                switch (value2)
                {
                    case noPlay:
                        player2Position += 0;
                        break;
                    case snake:
                        player2Position -= player1;
                        break;
                    case ladder:
                        player2Position += player2;
                        break;
                    default:
                        break;
                }
                if (player2Position < 0)
                    player2Position = 0;
                if (player2Position > 100)
                    player2Position -= player2;

                
                if (value1 == ladder)
                {
                    if (player1Position != 100)
                    {
                        Console.WriteLine("Player 1 got ladder");
                       goto repeat1;                        
                    }
                }
                if (value2 == ladder)
                {
                    if (player2Position != 100)
                    {
                        Console.WriteLine("Player 2 got ladder");
                        goto repeat2;                        
                    }
                }
                Console.WriteLine("Player 1 got {0} for rolling dice {1} time to get {2} position ", player1, diceRollTimes, player1Position);
                Console.WriteLine("Player 2 got {0} for rolling dice {1} time to get {2} position ", player2, diceRollTimes, player2Position);
            }
            if (player1Position == 100)
                Console.WriteLine("Player 1 won the game");
            else
                Console.WriteLine("Player 2 won the game");
        }
    }
}
