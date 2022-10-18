using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    internal class UseCase2
    {
        public static void RollDice()
        {
            int START_POSITION = 0;
            int END_POSITION = 100;
            int dieRolling;

            Random random = new Random();
            dieRolling = random.Next(1, 7);
            Console.WriteLine("Number on die is: " + dieRolling);
        }
    }
}
