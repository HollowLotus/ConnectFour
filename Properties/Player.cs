using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Player
    {
        public void UserInput(Board masterboard)
        {
            Console.WriteLine("Please select a column! ");
            int playerInput = int.Parse(Console.ReadLine());

            //Column One
            if (playerInput == 1)
            {
                for (int i = 35; i >= 0; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "X";
                        break;
                    }
                }
            }
            //Column Two
            if (playerInput == 2)
            {
                for (int i = 36; i >= 1; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "X";
                        break;
                    }
                }
            }
            //Column Three
            if (playerInput == 3)
            {
                for (int i = 37; i >= 2; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "X";
                        break;
                    }
                }
            }
            //Column Four
            if (playerInput == 4)
            {
                for (int i = 38; i >= 3; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "X";
                        break;
                    }
                }
            }
            //Column Five
            if (playerInput == 5)
            {
                for (int i = 39; i >= 4; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "X";
                        break;
                    }
                }
            }
            //Six
            if (playerInput == 6)
            {
                for (int i = 40; i >= 5; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "X";
                        break;
                    }
                }
            }
            //Seven
            if (playerInput == 7)
            {
                for (int i = 41; i >= 6; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "X";
                        break;
                    }
                }
            }
        }

        public void Robot(Board masterboard)
        {
            // Set one of the squares to 'O'
            Random random = new Random();
            int robotRandom = random.Next(1, 7);

            //Column One
            if (robotRandom == 1)
            {
                for (int i = 35; i >= 0; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "O";
                        break;
                    }
                }
            }
            //Column Two
            if (robotRandom == 2)
            {
                for (int i = 36; i >= 1; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "O";
                        break;
                    }
                }
            }
            //Column Three
            if (robotRandom == 3)
            {
                for (int i = 37; i >= 2; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "O";
                        break;
                    }
                }
            }
            //Column Four
            if (robotRandom == 4)
            {
                for (int i = 38; i >= 3; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "O";
                        break;
                    }
                }
            }
            //Column Five
            if (robotRandom == 5)
            {
                for (int i = 39; i >= 4; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "O";
                        break;
                    }
                }
            }
            //Six
            if (robotRandom == 6)
            {
                for (int i = 40; i >= 5; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "O";
                        break;
                    }
                }
            }
            //Seven
            if (robotRandom == 7)
            {
                for (int i = 41; i >= 6; i -= 7)
                {
                    if (masterboard.test[i] == "_")
                    {
                        masterboard.test[i] = "O";
                        break;
                    }
                }
            }
        }
    }
}
