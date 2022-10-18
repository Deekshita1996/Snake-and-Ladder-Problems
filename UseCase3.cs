using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    internal class UseCase3
    {
        int START_POSITION = 0;
        int END_POSITION = 100;
        public static void Winningposition()
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            Console.WriteLine("Player starts from zero position");

            Random random = new Random();
            int checkOptions = random.Next(0, 3);
            switch (checkOptions)
            {

                case 0:
                    {
                        Console.WriteLine("There will be no play.Player will be at same position");
                    }
                    break;
                case 1:
                    {
                        Console.WriteLine("Player moves ahead");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Player bitten by snake");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Start the game again");
                    }
                    break;

            }
        }
    }
}
                