using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Winner
    {
        public void ChickenDinner(Board masterboard)
        {
            //bool result = false;
            //Vertical Check
            for (int i = 35; i >= 0; i -= 7)
            {
                if ((masterboard.test[i] == "O" && masterboard.test[i+1] == "O" && masterboard.test[i+2] == "O" && masterboard.test[i+3] == "O") ||
                    (masterboard.test[i+1] == "O" && masterboard.test[i+2] == "O" && masterboard.test[i+3] == "O" && masterboard.test[i+4] == "O") ||
                    (masterboard.test[i+2] == "O" && masterboard.test[i+3] == "O" && masterboard.test[i+4] == "O" && masterboard.test[i+5] == "O") ||
                    (masterboard.test[i+3] == "O" && masterboard.test[i+4] == "O" && masterboard.test[i+5] == "O" && masterboard.test[i+6] == "O")
                    )
                {
                    masterboard.p++;
                    masterboard.Restart();
                    masterboard.Draw();
                    Console.WriteLine("play 2 wins");
                    break;
                }
                else if ((masterboard.test[i] == "X" && masterboard.test[i + 1] == "X" && masterboard.test[i + 2] == "X" && masterboard.test[i + 3] == "X") ||
                    (masterboard.test[i + 1] == "X" && masterboard.test[i + 2] == "X" && masterboard.test[i + 3] == "X" && masterboard.test[i + 4] == "X") ||
                    (masterboard.test[i + 2] == "X" && masterboard.test[i + 3] == "X" && masterboard.test[i + 4] == "X" && masterboard.test[i + 5] == "X") ||
                    (masterboard.test[i + 3] == "X" && masterboard.test[i + 4] == "X" && masterboard.test[i + 5] == "X" && masterboard.test[i + 6] == "X"))
                {
                    masterboard.p++;
                    masterboard.Restart();
                    masterboard.Draw();
                    Console.WriteLine("Play 1 wins");
                    break;
                }
            }
            //Horizontal Check
            for (int i = 0; i <= 6; ++i)
            {
                if ((masterboard.test[i] == "O" && masterboard.test[i+7] == "O" && masterboard.test[i+14] == "O" && masterboard.test[i+21] == "O") ||
                    (masterboard.test[i+7] == "O" && masterboard.test[i+14] == "O" && masterboard.test[i+21] == "O" && masterboard.test[i+28] == "O") ||
                    (masterboard.test[i+14] == "O" && masterboard.test[i+21] == "O" && masterboard.test[i+28] == "O" && masterboard.test[i+35] == "O"))
                {
                    masterboard.p++;
                    masterboard.Restart();
                    masterboard.Draw();
                    Console.WriteLine("play 2 wins");
                    break;
                }
                else if ((masterboard.test[i] == "X" && masterboard.test[i + 7] == "X" && masterboard.test[i + 14] == "X" && masterboard.test[i + 21] == "X") ||
                    (masterboard.test[i + 7] == "X" && masterboard.test[i + 14] == "X" && masterboard.test[i + 21] == "X" && masterboard.test[i + 28] == "X") ||
                    (masterboard.test[i + 14] == "X" && masterboard.test[i + 21] == "X" && masterboard.test[i + 28] == "X" && masterboard.test[i + 35] == "X"))
                {
                    masterboard.p++;
                    masterboard.Restart();
                    masterboard.Draw();
                    Console.WriteLine("play 1 wins");
                    break;
                }
            }
            //Diagonal Check
            for (int i = 0; i <= 3; ++i)
            {
                if ((masterboard.test[i] == "O" && masterboard.test[i+8] == "O" && masterboard.test[i+16] == "O" && masterboard.test[i+24] == "O") ||
                    (masterboard.test[i+7] == "O" && masterboard.test[i+15] == "O" && masterboard.test[i+23] == "O" && masterboard.test[i+31] == "O") ||
                    (masterboard.test[i+14] == "O" && masterboard.test[i+22] == "O" && masterboard.test[i+30] == "O" && masterboard.test[i+38] == "O") ||
                    (masterboard.test[i+3] == "O" && masterboard.test[i+9] == "O" && masterboard.test[i+15] == "O" && masterboard.test[i+21] == "O") ||
                    (masterboard.test[i+10] == "O" && masterboard.test[i+16] == "O" && masterboard.test[i+22] == "O" && masterboard.test[i+28] == "O") ||
                    (masterboard.test[i+17] == "O" && masterboard.test[i+23] == "O" && masterboard.test[i+29] == "O" && masterboard.test[i+35] == "O"))
                {
                    masterboard.p++;
                    masterboard.Restart();
                    masterboard.Draw();
                    Console.WriteLine("play 2 wins");
                    break;
                }
                else if ((masterboard.test[i] == "X" && masterboard.test[i + 8] == "X" && masterboard.test[i + 16] == "X" && masterboard.test[i + 24] == "X") ||
                    (masterboard.test[i + 7] == "X" && masterboard.test[i + 15] == "X" && masterboard.test[i + 23] == "X" && masterboard.test[i + 31] == "X") ||
                    (masterboard.test[i + 14] == "X" && masterboard.test[i + 22] == "X" && masterboard.test[i + 30] == "X" && masterboard.test[i + 38] == "X") ||
                    (masterboard.test[i + 3] == "X" && masterboard.test[i + 9] == "X" && masterboard.test[i + 15] == "X" && masterboard.test[i + 21] == "X") ||
                    (masterboard.test[i + 10] == "X" && masterboard.test[i + 16] == "X" && masterboard.test[i + 22] == "X" && masterboard.test[i + 28] == "X") ||
                    (masterboard.test[i + 17] == "X" && masterboard.test[i + 23] == "X" && masterboard.test[i + 29] == "X" && masterboard.test[i + 35] == "X"))
                {
                    masterboard.p++;
                    masterboard.Restart();
                    masterboard.Draw();
                    Console.WriteLine("play 1 wins");
                    break;
                }
            }
        }
    }
}
