using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Board
    {
        Winner whoWon = new Winner();
        Player test2 = new Player();
        public string[] test = new string[42];
        public int p = 0;
        const int rounds = 1;
        int ave = 0;

        public void Draw()
        {
            Restart();

            while (p < rounds)
            {
                ++ave;
                int counter = 0;
                for (int k = 0; k < 6; ++k)
                {
                    for (int i = 0; i < 7; ++i, ++counter)
                    {
                        
                        Console.Write(test[counter]);
                    }
                    Console.WriteLine();
                }
                
                Console.WriteLine("*************");
                test2.Robot(this);
                whoWon.ChickenDinner(this);

          
                test2.UserInput(this);
                whoWon.ChickenDinner(this);

            }
            Console.ReadLine();
        }

        public void Restart()
        {
            for (int j = 0; j < test.Length; ++j)
            {
                test[j] = "_";
            }
        }
    }
}
