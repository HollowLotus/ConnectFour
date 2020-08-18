using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Ai
    {
        const string empty = "_";
        const string play1 = "X";
        const string play2 = "O";

        public void RandomAi(Board masterboard)
        {
            // Set one of the squares to 'O'
            Random random = new Random();
            int robotRandom = random.Next(1, 8);
            
            //Column One
            if (robotRandom == 1)
            {
                for (int i = 35; i >= 0; i -= 7)
                {
                    if (masterboard.test[i] == empty)
                    {
                        masterboard.test[i] = play1;
                        break;
                    }
                }
            }
            //Column Two
            if (robotRandom == 2)
            {
                for (int i = 36; i >= 1; i -= 7)
                {
                    if (masterboard.test[i] == empty)
                    {
                        masterboard.test[i] = play1;
                        break;
                    }
                }
            }
            //Column Three
            if (robotRandom == 3)
            {
                for (int i = 37; i >= 2; i -= 7)
                {
                    if (masterboard.test[i] == empty)
                    {
                        masterboard.test[i] = play1;
                        break;
                    }
                }
            }
            //Column Four
            if (robotRandom == 4)
            {
                for (int i = 38; i >= 3; i -= 7)
                {
                    if (masterboard.test[i] == empty)
                    {
                        masterboard.test[i] = play1;
                        break;
                    }
                }
            }
            //Column Five
            if (robotRandom == 5)
            {
                for (int i = 39; i >= 4; i -= 7)
                {
                    if (masterboard.test[i] == empty)
                    {
                        masterboard.test[i] = play1;
                        break;
                    }
                }
            }
            //Six
            if (robotRandom == 6)
            {
                for (int i = 40; i >= 5; i -= 7)
                {
                    if (masterboard.test[i] == empty)
                    {
                        masterboard.test[i] = play1;
                        break;
                    }
                }
            }
            //Seven
            if (robotRandom == 7)
            {
                for (int i = 41; i >= 6; i -= 7)
                {
                    if (masterboard.test[i] == empty)
                    {
                        masterboard.test[i] = play1;
                        break;
                    }
                }
            }
        }
        public void NewAi(Board omega)
        {
            // Set one of the squares to 'O'
            //Blocker(omega);

            if ((omega.test[35] == empty && omega.test[36] == empty && omega.test[37] == empty && omega.test[38] == empty) ||
                (omega.test[35] == play2 && omega.test[36] == empty && omega.test[37] == empty && omega.test[38] == empty) ||
                (omega.test[35] == empty && omega.test[36] == play2 && omega.test[37] == empty && omega.test[38] == empty) ||
                (omega.test[35] == empty && omega.test[36] == empty && omega.test[37] == play2 && omega.test[38] == empty) ||
                (omega.test[35] == empty && omega.test[36] == empty && omega.test[37] == empty && omega.test[38] == play2) ||
                (omega.test[35] == play2 && omega.test[36] == play2 && omega.test[37] == empty && omega.test[38] == empty) ||
                (omega.test[35] == play2 && omega.test[36] == empty && omega.test[37] == play2 && omega.test[38] == empty) ||
                (omega.test[35] == play2 && omega.test[36] == empty && omega.test[37] == empty && omega.test[38] == play2) ||
                (omega.test[35] == empty && omega.test[36] == play2 && omega.test[37] == play2 && omega.test[38] == empty) ||
                (omega.test[35] == empty && omega.test[36] == play2 && omega.test[37] == empty && omega.test[38] == play2) ||
                (omega.test[35] == empty && omega.test[36] == empty && omega.test[37] == play2 && omega.test[38] == play2) ||
                (omega.test[35] == play2 && omega.test[36] == play2 && omega.test[37] == play2 && omega.test[38] == empty) ||
                (omega.test[35] == play2 && omega.test[36] == play2 && omega.test[37] == empty && omega.test[38] == play2) ||
                (omega.test[35] == empty && omega.test[36] == play2 && omega.test[37] == play2 && omega.test[38] == play2))
            {
                if (omega.test[35] == empty)
                {
                    omega.test[35] = play2;
                }
                else if (omega.test[36] == empty)
                {
                    omega.test[36] = play2;
                }
                else if (omega.test[37] == empty)
                {
                    omega.test[37] = play2;
                }
                else if (omega.test[38] == empty)
                {
                    omega.test[38] = play2;
                }
            }
            else if ((omega.test[36] == empty && omega.test[37] == empty && omega.test[38] == empty && omega.test[39] == empty) ||
            (omega.test[36] == play2 && omega.test[37] == empty && omega.test[38] == empty && omega.test[39] == empty) ||
            (omega.test[36] == empty && omega.test[37] == play2 && omega.test[38] == empty && omega.test[39] == empty) ||
            (omega.test[36] == empty && omega.test[37] == empty && omega.test[38] == play2 && omega.test[39] == empty) ||
            (omega.test[36] == empty && omega.test[37] == empty && omega.test[38] == empty && omega.test[39] == play2) ||
            (omega.test[36] == play2 && omega.test[37] == play2 && omega.test[38] == empty && omega.test[39] == empty) ||
            (omega.test[36] == play2 && omega.test[37] == empty && omega.test[38] == play2 && omega.test[39] == empty) ||
            (omega.test[36] == play2 && omega.test[37] == empty && omega.test[38] == empty && omega.test[39] == play2) ||
            (omega.test[36] == empty && omega.test[37] == play2 && omega.test[38] == play2 && omega.test[39] == empty) ||
            (omega.test[36] == empty && omega.test[37] == play2 && omega.test[38] == empty && omega.test[39] == play2) ||
            (omega.test[36] == empty && omega.test[37] == empty && omega.test[38] == play2 && omega.test[39] == play2) ||
            (omega.test[36] == play2 && omega.test[37] == play2 && omega.test[38] == play2 && omega.test[39] == empty) ||
            (omega.test[36] == play2 && omega.test[37] == play2 && omega.test[38] == empty && omega.test[39] == play2) ||
            (omega.test[36] == empty && omega.test[37] == play2 && omega.test[38] == play2 && omega.test[39] == play2))
            {
                if (omega.test[36] == empty)
                {
                    omega.test[36] = play2;
                }
                else if (omega.test[37] == empty)
                {
                    omega.test[37] = play2;
                }
                else if (omega.test[38] == empty)
                {
                    omega.test[38] = play2;
                }
                else if (omega.test[39] == empty)
                {
                    omega.test[39] = play2;
                }
            }
            else if ((omega.test[37] == empty && omega.test[38] == empty && omega.test[39] == empty && omega.test[40] == empty) ||
            (omega.test[37] == play2 && omega.test[38] == empty && omega.test[39] == empty && omega.test[40] == empty) ||
            (omega.test[37] == empty && omega.test[38] == play2 && omega.test[39] == empty && omega.test[40] == empty) ||
            (omega.test[37] == empty && omega.test[38] == empty && omega.test[39] == play2 && omega.test[40] == empty) ||
            (omega.test[37] == empty && omega.test[38] == empty && omega.test[39] == empty && omega.test[40] == play2) ||
            (omega.test[37] == play2 && omega.test[38] == play2 && omega.test[39] == empty && omega.test[40] == empty) ||
            (omega.test[37] == play2 && omega.test[38] == empty && omega.test[39] == play2 && omega.test[40] == empty) ||
            (omega.test[37] == play2 && omega.test[38] == empty && omega.test[39] == empty && omega.test[40] == play2) ||
            (omega.test[37] == empty && omega.test[38] == play2 && omega.test[39] == play2 && omega.test[40] == empty) ||
            (omega.test[37] == empty && omega.test[38] == play2 && omega.test[39] == empty && omega.test[40] == play2) ||
            (omega.test[37] == empty && omega.test[38] == empty && omega.test[39] == play2 && omega.test[40] == play2) ||
            (omega.test[37] == play2 && omega.test[38] == play2 && omega.test[39] == play2 && omega.test[40] == empty) ||
            (omega.test[37] == play2 && omega.test[38] == play2 && omega.test[39] == empty && omega.test[40] == play2) ||
            (omega.test[37] == empty && omega.test[38] == play2 && omega.test[39] == play2 && omega.test[40] == play2))
            {
                if (omega.test[37] == empty)
                {
                    omega.test[37] = play2;
                }
                else if (omega.test[38] == empty)
                {
                    omega.test[38] = play2;
                }
                else if (omega.test[39] == empty)
                {
                    omega.test[39] = play2;
                }
                else if (omega.test[40] == empty)
                {
                    omega.test[40] = play2;
                }
            }
            else if ((omega.test[38] == empty && omega.test[39] == empty && omega.test[40] == empty && omega.test[41] == empty) ||
            (omega.test[38] == play2 && omega.test[39] == empty && omega.test[40] == empty && omega.test[41] == empty) ||
            (omega.test[38] == empty && omega.test[39] == play2 && omega.test[40] == empty && omega.test[41] == empty) ||
            (omega.test[38] == empty && omega.test[39] == empty && omega.test[40] == play2 && omega.test[41] == empty) ||
            (omega.test[38] == empty && omega.test[39] == empty && omega.test[40] == empty && omega.test[41] == play2) ||
            (omega.test[38] == play2 && omega.test[39] == play2 && omega.test[40] == empty && omega.test[41] == empty) ||
            (omega.test[38] == play2 && omega.test[39] == empty && omega.test[40] == play2 && omega.test[41] == empty) ||
            (omega.test[38] == play2 && omega.test[39] == empty && omega.test[40] == empty && omega.test[41] == play2) ||
            (omega.test[38] == empty && omega.test[39] == play2 && omega.test[40] == play2 && omega.test[41] == empty) ||
            (omega.test[38] == empty && omega.test[39] == play2 && omega.test[40] == empty && omega.test[41] == play2) ||
            (omega.test[38] == empty && omega.test[39] == empty && omega.test[40] == play2 && omega.test[41] == play2) ||
            (omega.test[38] == play2 && omega.test[39] == play2 && omega.test[40] == play2 && omega.test[41] == empty) ||
            (omega.test[38] == play2 && omega.test[39] == play2 && omega.test[40] == empty && omega.test[41] == play2) ||
            (omega.test[38] == empty && omega.test[39] == play2 && omega.test[40] == play2 && omega.test[41] == play2))
            {
                if (omega.test[38] == empty)
                {
                    omega.test[38] = play2;
                }
                else if (omega.test[39] == empty)
                {
                    omega.test[39] = play2;
                }
                else if (omega.test[40] == empty)
                {
                    omega.test[40] = play2;
                }
                else if (omega.test[41] == empty)
                {
                    omega.test[41] = play2;
                }
            }
            else if ((omega.test[35] == empty && omega.test[28] == empty && omega.test[21] == empty && omega.test[14] == empty) ||
            (omega.test[35] == play2 && omega.test[28] == empty && omega.test[21] == empty && omega.test[14] == empty) ||
            (omega.test[35] == empty && omega.test[28] == play2 && omega.test[21] == empty && omega.test[14] == empty) ||
            (omega.test[35] == empty && omega.test[28] == empty && omega.test[21] == play2 && omega.test[14] == empty) ||
            (omega.test[35] == empty && omega.test[28] == empty && omega.test[21] == empty && omega.test[14] == play2) ||
            (omega.test[35] == play2 && omega.test[28] == play2 && omega.test[21] == empty && omega.test[14] == empty) ||
            (omega.test[35] == play2 && omega.test[28] == empty && omega.test[21] == play2 && omega.test[14] == empty) ||
            (omega.test[35] == play2 && omega.test[28] == empty && omega.test[21] == empty && omega.test[14] == play2) ||
            (omega.test[35] == empty && omega.test[28] == play2 && omega.test[21] == play2 && omega.test[14] == empty) ||
            (omega.test[35] == empty && omega.test[28] == play2 && omega.test[21] == empty && omega.test[14] == play2) ||
            (omega.test[35] == empty && omega.test[28] == empty && omega.test[21] == play2 && omega.test[14] == play2) ||
            (omega.test[35] == play2 && omega.test[28] == play2 && omega.test[21] == play2 && omega.test[14] == empty) ||
            (omega.test[35] == play2 && omega.test[28] == play2 && omega.test[21] == empty && omega.test[14] == play2) ||
            (omega.test[35] == empty && omega.test[28] == play2 && omega.test[21] == play2 && omega.test[14] == play2))
            {
                if (omega.test[35] == empty)
                {
                    omega.test[35] = play2;
                }
                else if (omega.test[28] == empty)
                {
                    omega.test[28] = play2;
                }
                else if (omega.test[21] == empty)
                {
                    omega.test[21] = play2;
                }
                else if (omega.test[14] == empty)
                {
                    omega.test[14] = play2;
                }
            }
            else if ((omega.test[36] == empty && omega.test[29] == empty && omega.test[22] == empty && omega.test[15] == empty) ||
            (omega.test[36] == play2 && omega.test[29] == empty && omega.test[22] == empty && omega.test[15] == empty) ||
            (omega.test[36] == empty && omega.test[29] == play2 && omega.test[22] == empty && omega.test[15] == empty) ||
            (omega.test[36] == empty && omega.test[29] == empty && omega.test[22] == play2 && omega.test[15] == empty) ||
            (omega.test[36] == empty && omega.test[29] == empty && omega.test[22] == empty && omega.test[15] == play2) ||
            (omega.test[36] == play2 && omega.test[29] == play2 && omega.test[22] == empty && omega.test[15] == empty) ||
            (omega.test[36] == play2 && omega.test[29] == empty && omega.test[22] == play2 && omega.test[15] == empty) ||
            (omega.test[36] == play2 && omega.test[29] == empty && omega.test[22] == empty && omega.test[15] == play2) ||
            (omega.test[36] == empty && omega.test[29] == play2 && omega.test[22] == play2 && omega.test[15] == empty) ||
            (omega.test[36] == empty && omega.test[29] == play2 && omega.test[22] == empty && omega.test[15] == play2) ||
            (omega.test[36] == empty && omega.test[29] == empty && omega.test[22] == play2 && omega.test[15] == play2) ||
            (omega.test[36] == play2 && omega.test[29] == play2 && omega.test[22] == play2 && omega.test[15] == empty) ||
            (omega.test[36] == play2 && omega.test[29] == play2 && omega.test[22] == empty && omega.test[15] == play2) ||
            (omega.test[36] == empty && omega.test[29] == play2 && omega.test[22] == play2 && omega.test[15] == play2))
            {
                if (omega.test[36] == empty)
                {
                    omega.test[36] = play2;
                }
                else if (omega.test[29] == empty)
                {
                    omega.test[29] = play2;
                }
                else if (omega.test[22] == empty)
                {
                    omega.test[22] = play2;
                }
                else if (omega.test[15] == empty)
                {
                    omega.test[15] = play2;
                }
            }
            else if ((omega.test[37] == empty && omega.test[30] == empty && omega.test[23] == empty && omega.test[16] == empty) ||
            (omega.test[37] == play2 && omega.test[30] == empty && omega.test[23] == empty && omega.test[16] == empty) ||
            (omega.test[37] == empty && omega.test[30] == play2 && omega.test[23] == empty && omega.test[16] == empty) ||
            (omega.test[37] == empty && omega.test[30] == empty && omega.test[23] == play2 && omega.test[16] == empty) ||
            (omega.test[37] == empty && omega.test[30] == empty && omega.test[23] == empty && omega.test[16] == play2) ||
            (omega.test[37] == play2 && omega.test[30] == play2 && omega.test[23] == empty && omega.test[16] == empty) ||
            (omega.test[37] == play2 && omega.test[30] == empty && omega.test[23] == play2 && omega.test[16] == empty) ||
            (omega.test[37] == play2 && omega.test[30] == empty && omega.test[23] == empty && omega.test[16] == play2) ||
            (omega.test[37] == empty && omega.test[30] == play2 && omega.test[23] == play2 && omega.test[16] == empty) ||
            (omega.test[37] == empty && omega.test[30] == play2 && omega.test[23] == empty && omega.test[16] == play2) ||
            (omega.test[37] == empty && omega.test[30] == empty && omega.test[23] == play2 && omega.test[16] == play2) ||
            (omega.test[37] == play2 && omega.test[30] == play2 && omega.test[23] == play2 && omega.test[16] == empty) ||
            (omega.test[37] == play2 && omega.test[30] == play2 && omega.test[23] == empty && omega.test[16] == play2) ||
            (omega.test[37] == empty && omega.test[30] == play2 && omega.test[23] == play2 && omega.test[16] == play2))
            {
                if (omega.test[37] == empty)
                {
                    omega.test[37] = play2;
                }
                else if (omega.test[30] == empty)
                {
                    omega.test[30] = play2;
                }
                else if (omega.test[23] == empty)
                {
                    omega.test[23] = play2;
                }
                else if (omega.test[16] == empty)
                {
                    omega.test[16] = play2;
                }
            }
            else if ((omega.test[38] == empty && omega.test[31] == empty && omega.test[24] == empty && omega.test[17] == empty) ||
            (omega.test[38] == play2 && omega.test[31] == empty && omega.test[24] == empty && omega.test[17] == empty) ||
            (omega.test[38] == empty && omega.test[31] == play2 && omega.test[24] == empty && omega.test[17] == empty) ||
            (omega.test[38] == empty && omega.test[31] == empty && omega.test[24] == play2 && omega.test[17] == empty) ||
            (omega.test[38] == empty && omega.test[31] == empty && omega.test[24] == empty && omega.test[17] == play2) ||
            (omega.test[38] == play2 && omega.test[31] == play2 && omega.test[24] == empty && omega.test[17] == empty) ||
            (omega.test[38] == play2 && omega.test[31] == empty && omega.test[24] == play2 && omega.test[17] == empty) ||
            (omega.test[38] == play2 && omega.test[31] == empty && omega.test[24] == empty && omega.test[17] == play2) ||
            (omega.test[38] == empty && omega.test[31] == play2 && omega.test[24] == play2 && omega.test[17] == empty) ||
            (omega.test[38] == empty && omega.test[31] == play2 && omega.test[24] == empty && omega.test[17] == play2) ||
            (omega.test[38] == empty && omega.test[31] == empty && omega.test[24] == play2 && omega.test[17] == play2) ||
            (omega.test[38] == play2 && omega.test[31] == play2 && omega.test[24] == play2 && omega.test[17] == empty) ||
            (omega.test[38] == play2 && omega.test[31] == play2 && omega.test[24] == empty && omega.test[17] == play2) ||
            (omega.test[38] == empty && omega.test[31] == play2 && omega.test[24] == play2 && omega.test[17] == play2))
            {
                if (omega.test[38] == empty)
                {
                    omega.test[38] = play2;
                }
                else if (omega.test[31] == empty)
                {
                    omega.test[31] = play2;
                }
                else if (omega.test[24] == empty)
                {
                    omega.test[24] = play2;
                }
                else if (omega.test[17] == empty)
                {
                    omega.test[17] = play2;
                }
            }
            else if ((omega.test[39] == empty && omega.test[32] == empty && omega.test[25] == empty && omega.test[18] == empty) ||
            (omega.test[39] == play2 && omega.test[32] == empty && omega.test[25] == empty && omega.test[18] == empty) ||
            (omega.test[39] == empty && omega.test[32] == play2 && omega.test[25] == empty && omega.test[18] == empty) ||
            (omega.test[39] == empty && omega.test[32] == empty && omega.test[25] == play2 && omega.test[18] == empty) ||
            (omega.test[39] == empty && omega.test[32] == empty && omega.test[25] == empty && omega.test[18] == play2) ||
            (omega.test[39] == play2 && omega.test[32] == play2 && omega.test[25] == empty && omega.test[18] == empty) ||
            (omega.test[39] == play2 && omega.test[32] == empty && omega.test[25] == play2 && omega.test[18] == empty) ||
            (omega.test[39] == play2 && omega.test[32] == empty && omega.test[25] == empty && omega.test[18] == play2) ||
            (omega.test[39] == empty && omega.test[32] == play2 && omega.test[25] == play2 && omega.test[18] == empty) ||
            (omega.test[39] == empty && omega.test[32] == play2 && omega.test[25] == empty && omega.test[18] == play2) ||
            (omega.test[39] == empty && omega.test[32] == empty && omega.test[25] == play2 && omega.test[18] == play2) ||
            (omega.test[39] == play2 && omega.test[32] == play2 && omega.test[25] == play2 && omega.test[18] == empty) ||
            (omega.test[39] == play2 && omega.test[32] == play2 && omega.test[25] == empty && omega.test[18] == play2) ||
            (omega.test[39] == empty && omega.test[32] == play2 && omega.test[25] == play2 && omega.test[18] == play2))
            {
                if (omega.test[39] == empty)
                {
                    omega.test[39] = play2;
                }
                else if (omega.test[32] == empty)
                {
                    omega.test[32] = play2;
                }
                else if (omega.test[25] == empty)
                {
                    omega.test[25] = play2;
                }
                else if (omega.test[18] == empty)
                {
                    omega.test[18] = play2;
                }
            }
            else if ((omega.test[40] == empty && omega.test[33] == empty && omega.test[26] == empty && omega.test[19] == empty) ||
            (omega.test[40] == play2 && omega.test[33] == empty && omega.test[26] == empty && omega.test[19] == empty) ||
            (omega.test[40] == empty && omega.test[33] == play2 && omega.test[26] == empty && omega.test[19] == empty) ||
            (omega.test[40] == empty && omega.test[33] == empty && omega.test[26] == play2 && omega.test[19] == empty) ||
            (omega.test[40] == empty && omega.test[33] == empty && omega.test[26] == empty && omega.test[19] == play2) ||
            (omega.test[40] == play2 && omega.test[33] == play2 && omega.test[26] == empty && omega.test[19] == empty) ||
            (omega.test[40] == play2 && omega.test[33] == empty && omega.test[26] == play2 && omega.test[19] == empty) ||
            (omega.test[40] == play2 && omega.test[33] == empty && omega.test[26] == empty && omega.test[19] == play2) ||
            (omega.test[40] == empty && omega.test[33] == play2 && omega.test[26] == play2 && omega.test[19] == empty) ||
            (omega.test[40] == empty && omega.test[33] == play2 && omega.test[26] == empty && omega.test[19] == play2) ||
            (omega.test[40] == empty && omega.test[33] == empty && omega.test[26] == play2 && omega.test[19] == play2) ||
            (omega.test[40] == play2 && omega.test[33] == play2 && omega.test[26] == play2 && omega.test[19] == empty) ||
            (omega.test[40] == play2 && omega.test[33] == play2 && omega.test[26] == empty && omega.test[19] == play2) ||
            (omega.test[40] == empty && omega.test[33] == play2 && omega.test[26] == play2 && omega.test[19] == play2))
            {
                if (omega.test[40] == empty)
                {
                    omega.test[40] = play2;
                }
                else if (omega.test[33] == empty)
                {
                    omega.test[33] = play2;
                }
                else if (omega.test[26] == empty)
                {
                    omega.test[26] = play2;
                }
                else if (omega.test[19] == empty)
                {
                    omega.test[19] = play2;
                }
            }
            else if ((omega.test[41] == empty && omega.test[34] == empty && omega.test[27] == empty && omega.test[20] == empty) ||
            (omega.test[41] == play2 && omega.test[34] == empty && omega.test[27] == empty && omega.test[20] == empty) ||
            (omega.test[41] == empty && omega.test[34] == play2 && omega.test[27] == empty && omega.test[20] == empty) ||
            (omega.test[41] == empty && omega.test[34] == empty && omega.test[27] == play2 && omega.test[20] == empty) ||
            (omega.test[41] == empty && omega.test[34] == empty && omega.test[27] == empty && omega.test[20] == play2) ||
            (omega.test[41] == play2 && omega.test[34] == play2 && omega.test[27] == empty && omega.test[20] == empty) ||
            (omega.test[41] == play2 && omega.test[34] == empty && omega.test[27] == play2 && omega.test[20] == empty) ||
            (omega.test[41] == play2 && omega.test[34] == empty && omega.test[27] == empty && omega.test[20] == play2) ||
            (omega.test[41] == empty && omega.test[34] == play2 && omega.test[27] == play2 && omega.test[20] == empty) ||
            (omega.test[41] == empty && omega.test[34] == play2 && omega.test[27] == empty && omega.test[20] == play2) ||
            (omega.test[41] == empty && omega.test[34] == empty && omega.test[27] == play2 && omega.test[20] == play2) ||
            (omega.test[41] == play2 && omega.test[34] == play2 && omega.test[27] == play2 && omega.test[20] == empty) ||
            (omega.test[41] == play2 && omega.test[34] == play2 && omega.test[27] == empty && omega.test[20] == play2) ||
            (omega.test[41] == empty && omega.test[34] == play2 && omega.test[27] == play2 && omega.test[20] == play2))
            {
                if (omega.test[41] == empty)
                {
                    omega.test[41] = play2;
                }
                else if (omega.test[34] == empty)
                {
                    omega.test[34] = play2;
                }
                else if (omega.test[27] == empty)
                {
                    omega.test[27] = play2;
                }
                else if (omega.test[20] == empty)
                {
                    omega.test[20] = play2;
                }
            }
            // Second Level Row
            else if (omega.test[35] != empty && omega.test[36] != empty && omega.test[37] != empty && omega.test[38] != empty)
            {
                if ((omega.test[28] == empty && omega.test[29] == empty && omega.test[30] == empty && omega.test[31] == empty) ||
                (omega.test[28] == play2 && omega.test[29] == empty && omega.test[30] == empty && omega.test[31] == empty) ||
                (omega.test[28] == empty && omega.test[29] == play2 && omega.test[30] == empty && omega.test[31] == empty) ||
                (omega.test[28] == empty && omega.test[29] == empty && omega.test[30] == play2 && omega.test[31] == empty) ||
                (omega.test[28] == empty && omega.test[29] == empty && omega.test[30] == empty && omega.test[31] == play2) ||
                (omega.test[28] == play2 && omega.test[29] == play2 && omega.test[30] == empty && omega.test[31] == empty) ||
                (omega.test[28] == play2 && omega.test[29] == empty && omega.test[30] == play2 && omega.test[31] == empty) ||
                (omega.test[28] == play2 && omega.test[29] == empty && omega.test[30] == empty && omega.test[31] == play2) ||
                (omega.test[28] == empty && omega.test[29] == play2 && omega.test[30] == play2 && omega.test[31] == empty) ||
                (omega.test[28] == empty && omega.test[29] == play2 && omega.test[30] == empty && omega.test[31] == play2) ||
                (omega.test[28] == empty && omega.test[29] == empty && omega.test[30] == play2 && omega.test[31] == play2) ||
                (omega.test[28] == play2 && omega.test[29] == play2 && omega.test[30] == play2 && omega.test[31] == empty) ||
                (omega.test[28] == play2 && omega.test[29] == play2 && omega.test[30] == empty && omega.test[31] == play2) ||
                (omega.test[28] == empty && omega.test[29] == play2 && omega.test[30] == play2 && omega.test[31] == play2))
                {
                    if (omega.test[28] == empty)
                    {
                        omega.test[28] = play2;
                    }
                    else if (omega.test[29] == empty)
                    {
                        omega.test[29] = play2;
                    }
                    else if (omega.test[30] == empty)
                    {
                        omega.test[30] = play2;
                    }
                    else if (omega.test[31] == empty)
                    {
                        omega.test[31] = play2;
                    }
                }
            }
            else if (omega.test[36] != empty && omega.test[37] != empty && omega.test[38] != empty && omega.test[39] != empty)
            {
                if ((omega.test[29] == empty && omega.test[30] == empty && omega.test[31] == empty && omega.test[32] == empty) ||
                (omega.test[29] == play2 && omega.test[30] == empty && omega.test[31] == empty && omega.test[32] == empty) ||
                (omega.test[29] == empty && omega.test[30] == play2 && omega.test[31] == empty && omega.test[32] == empty) ||
                (omega.test[29] == empty && omega.test[30] == empty && omega.test[31] == play2 && omega.test[32] == empty) ||
                (omega.test[29] == empty && omega.test[30] == empty && omega.test[31] == empty && omega.test[32] == play2) ||
                (omega.test[29] == play2 && omega.test[30] == play2 && omega.test[31] == empty && omega.test[32] == empty) ||
                (omega.test[29] == play2 && omega.test[30] == empty && omega.test[31] == play2 && omega.test[32] == empty) ||
                (omega.test[29] == play2 && omega.test[30] == empty && omega.test[31] == empty && omega.test[32] == play2) ||
                (omega.test[29] == empty && omega.test[30] == play2 && omega.test[31] == play2 && omega.test[32] == empty) ||
                (omega.test[29] == empty && omega.test[30] == play2 && omega.test[31] == empty && omega.test[32] == play2) ||
                (omega.test[29] == empty && omega.test[30] == empty && omega.test[31] == play2 && omega.test[32] == play2) ||
                (omega.test[29] == play2 && omega.test[30] == play2 && omega.test[31] == play2 && omega.test[32] == empty) ||
                (omega.test[29] == play2 && omega.test[30] == play2 && omega.test[31] == empty && omega.test[32] == play2) ||
                (omega.test[29] == empty && omega.test[30] == play2 && omega.test[31] == play2 && omega.test[32] == play2))
                {
                    if (omega.test[29] == empty)
                    {
                        omega.test[29] = play2;
                    }
                    else if (omega.test[30] == empty)
                    {
                        omega.test[30] = play2;
                    }
                    else if (omega.test[31] == empty)
                    {
                        omega.test[31] = play2;
                    }
                    else if (omega.test[32] == empty)
                    {
                        omega.test[32] = play2;
                    }
                }
            }
            else if (omega.test[37] != empty && omega.test[38] != empty && omega.test[39] != empty && omega.test[40] != empty)
            {
                if ((omega.test[30] == empty && omega.test[31] == empty && omega.test[32] == empty && omega.test[33] == empty) ||
                (omega.test[30] == play2 && omega.test[31] == empty && omega.test[32] == empty && omega.test[33] == empty) ||
                (omega.test[30] == empty && omega.test[31] == play2 && omega.test[32] == empty && omega.test[33] == empty) ||
                (omega.test[30] == empty && omega.test[31] == empty && omega.test[32] == play2 && omega.test[33] == empty) ||
                (omega.test[30] == empty && omega.test[31] == empty && omega.test[32] == empty && omega.test[33] == play2) ||
                (omega.test[30] == play2 && omega.test[31] == play2 && omega.test[32] == empty && omega.test[33] == empty) ||
                (omega.test[30] == play2 && omega.test[31] == empty && omega.test[32] == play2 && omega.test[33] == empty) ||
                (omega.test[30] == play2 && omega.test[31] == empty && omega.test[32] == empty && omega.test[33] == play2) ||
                (omega.test[30] == empty && omega.test[31] == play2 && omega.test[32] == play2 && omega.test[33] == empty) ||
                (omega.test[30] == empty && omega.test[31] == play2 && omega.test[32] == empty && omega.test[33] == play2) ||
                (omega.test[30] == empty && omega.test[31] == empty && omega.test[32] == play2 && omega.test[33] == play2) ||
                (omega.test[30] == play2 && omega.test[31] == play2 && omega.test[32] == play2 && omega.test[33] == empty) ||
                (omega.test[30] == play2 && omega.test[31] == play2 && omega.test[32] == empty && omega.test[33] == play2) ||
                (omega.test[30] == empty && omega.test[31] == play2 && omega.test[32] == play2 && omega.test[33] == play2))
                {
                    if (omega.test[30] == empty)
                    {
                        omega.test[30] = play2;
                    }
                    else if (omega.test[31] == empty)
                    {
                        omega.test[31] = play2;
                    }
                    else if (omega.test[32] == empty)
                    {
                        omega.test[32] = play2;
                    }
                    else if (omega.test[33] == empty)
                    {
                        omega.test[33] = play2;
                    }
                }
            }
            else if (omega.test[38] != empty && omega.test[39] != empty && omega.test[40] != empty && omega.test[41] != empty)
            {
                if ((omega.test[31] == empty && omega.test[32] == empty && omega.test[33] == empty && omega.test[34] == empty) ||
                (omega.test[31] == play2 && omega.test[32] == empty && omega.test[33] == empty && omega.test[34] == empty) ||
                (omega.test[31] == empty && omega.test[32] == play2 && omega.test[33] == empty && omega.test[34] == empty) ||
                (omega.test[31] == empty && omega.test[32] == empty && omega.test[33] == play2 && omega.test[34] == empty) ||
                (omega.test[31] == empty && omega.test[32] == empty && omega.test[33] == empty && omega.test[34] == play2) ||
                (omega.test[31] == play2 && omega.test[32] == play2 && omega.test[33] == empty && omega.test[34] == empty) ||
                (omega.test[31] == play2 && omega.test[32] == empty && omega.test[33] == play2 && omega.test[34] == empty) ||
                (omega.test[31] == play2 && omega.test[32] == empty && omega.test[33] == empty && omega.test[34] == play2) ||
                (omega.test[31] == empty && omega.test[32] == play2 && omega.test[33] == play2 && omega.test[34] == empty) ||
                (omega.test[31] == empty && omega.test[32] == play2 && omega.test[33] == empty && omega.test[34] == play2) ||
                (omega.test[31] == empty && omega.test[32] == empty && omega.test[33] == play2 && omega.test[34] == play2) ||
                (omega.test[31] == play2 && omega.test[32] == play2 && omega.test[33] == play2 && omega.test[34] == empty) ||
                (omega.test[31] == play2 && omega.test[32] == play2 && omega.test[33] == empty && omega.test[34] == play2) ||
                (omega.test[31] == empty && omega.test[32] == play2 && omega.test[33] == play2 && omega.test[34] == play2))
                {
                    if (omega.test[31] == empty)
                    {
                        omega.test[31] = play2;
                    }
                    else if (omega.test[32] == empty)
                    {
                        omega.test[32] = play2;
                    }
                    else if (omega.test[33] == empty)
                    {
                        omega.test[33] = play2;
                    }
                    else if (omega.test[34] == empty)
                    {
                        omega.test[34] = play2;
                    }
                }
            }

            // Second Level Vertical 
            else if (omega.test[35] != empty)
            {
                if ((omega.test[28] == empty && omega.test[21] == empty && omega.test[14] == empty && omega.test[7] == empty) ||
                (omega.test[28] == play2 && omega.test[21] == empty && omega.test[14] == empty && omega.test[7] == empty) ||
                (omega.test[28] == empty && omega.test[21] == play2 && omega.test[14] == empty && omega.test[7] == empty) ||
                (omega.test[28] == empty && omega.test[21] == empty && omega.test[14] == play2 && omega.test[7] == empty) ||
                (omega.test[28] == empty && omega.test[21] == empty && omega.test[14] == empty && omega.test[7] == play2) ||
                (omega.test[28] == play2 && omega.test[21] == play2 && omega.test[14] == empty && omega.test[7] == empty) ||
                (omega.test[28] == play2 && omega.test[21] == empty && omega.test[14] == play2 && omega.test[7] == empty) ||
                (omega.test[28] == play2 && omega.test[21] == empty && omega.test[14] == empty && omega.test[7] == play2) ||
                (omega.test[28] == empty && omega.test[21] == play2 && omega.test[14] == play2 && omega.test[7] == empty) ||
                (omega.test[28] == empty && omega.test[21] == play2 && omega.test[14] == empty && omega.test[7] == play2) ||
                (omega.test[28] == empty && omega.test[21] == empty && omega.test[14] == play2 && omega.test[7] == play2) ||
                (omega.test[28] == play2 && omega.test[21] == play2 && omega.test[14] == play2 && omega.test[7] == empty) ||
                (omega.test[28] == play2 && omega.test[21] == play2 && omega.test[14] == empty && omega.test[7] == play2) ||
                (omega.test[28] == empty && omega.test[21] == play2 && omega.test[14] == play2 && omega.test[7] == play2))
                {
                    if (omega.test[28] == empty)
                    {
                        omega.test[28] = play2;
                    }
                    else if (omega.test[21] == empty)
                    {
                        omega.test[21] = play2;
                    }
                    else if (omega.test[14] == empty)
                    {
                        omega.test[14] = play2;
                    }
                    else if (omega.test[7] == empty)
                    {
                        omega.test[7] = play2;
                    }
                }
            }
            else if (omega.test[36] != empty)
            {
                if ((omega.test[29] == empty && omega.test[22] == empty && omega.test[15] == empty && omega.test[8] == empty) ||
                (omega.test[29] == play2 && omega.test[22] == empty && omega.test[15] == empty && omega.test[8] == empty) ||
                (omega.test[29] == empty && omega.test[22] == play2 && omega.test[15] == empty && omega.test[8] == empty) ||
                (omega.test[29] == empty && omega.test[22] == empty && omega.test[15] == play2 && omega.test[8] == empty) ||
                (omega.test[29] == empty && omega.test[22] == empty && omega.test[15] == empty && omega.test[8] == play2) ||
                (omega.test[29] == play2 && omega.test[22] == play2 && omega.test[15] == empty && omega.test[8] == empty) ||
                (omega.test[29] == play2 && omega.test[22] == empty && omega.test[15] == play2 && omega.test[8] == empty) ||
                (omega.test[29] == play2 && omega.test[22] == empty && omega.test[15] == empty && omega.test[8] == play2) ||
                (omega.test[29] == empty && omega.test[22] == play2 && omega.test[15] == play2 && omega.test[8] == empty) ||
                (omega.test[29] == empty && omega.test[22] == play2 && omega.test[15] == empty && omega.test[8] == play2) ||
                (omega.test[29] == empty && omega.test[22] == empty && omega.test[15] == play2 && omega.test[8] == play2) ||
                (omega.test[29] == play2 && omega.test[22] == play2 && omega.test[15] == play2 && omega.test[8] == empty) ||
                (omega.test[29] == play2 && omega.test[22] == play2 && omega.test[15] == empty && omega.test[8] == play2) ||
                (omega.test[29] == empty && omega.test[22] == play2 && omega.test[15] == play2 && omega.test[8] == play2))
                {
                    if (omega.test[29] == empty)
                    {
                        omega.test[29] = play2;
                    }
                    else if (omega.test[22] == empty)
                    {
                        omega.test[22] = play2;
                    }
                    else if (omega.test[15] == empty)
                    {
                        omega.test[15] = play2;
                    }
                    else if (omega.test[8] == empty)
                    {
                        omega.test[8] = play2;
                    }
                }
            }
            else if (omega.test[37] != empty)
            {
                if ((omega.test[30] == empty && omega.test[23] == empty && omega.test[16] == empty && omega.test[9] == empty) ||
                (omega.test[30] == play2 && omega.test[23] == empty && omega.test[16] == empty && omega.test[9] == empty) ||
                (omega.test[30] == empty && omega.test[23] == play2 && omega.test[16] == empty && omega.test[9] == empty) ||
                (omega.test[30] == empty && omega.test[23] == empty && omega.test[16] == play2 && omega.test[9] == empty) ||
                (omega.test[30] == empty && omega.test[23] == empty && omega.test[16] == empty && omega.test[9] == play2) ||
                (omega.test[30] == play2 && omega.test[23] == play2 && omega.test[16] == empty && omega.test[9] == empty) ||
                (omega.test[30] == play2 && omega.test[23] == empty && omega.test[16] == play2 && omega.test[9] == empty) ||
                (omega.test[30] == play2 && omega.test[23] == empty && omega.test[16] == empty && omega.test[9] == play2) ||
                (omega.test[30] == empty && omega.test[23] == play2 && omega.test[16] == play2 && omega.test[9] == empty) ||
                (omega.test[30] == empty && omega.test[23] == play2 && omega.test[16] == empty && omega.test[9] == play2) ||
                (omega.test[30] == empty && omega.test[23] == empty && omega.test[16] == play2 && omega.test[9] == play2) ||
                (omega.test[30] == play2 && omega.test[23] == play2 && omega.test[16] == play2 && omega.test[9] == empty) ||
                (omega.test[30] == play2 && omega.test[23] == play2 && omega.test[16] == empty && omega.test[9] == play2) ||
                (omega.test[30] == empty && omega.test[23] == play2 && omega.test[16] == play2 && omega.test[9] == play2))
                {
                    if (omega.test[30] == empty)
                    {
                        omega.test[30] = play2;
                    }
                    else if (omega.test[23] == empty)
                    {
                        omega.test[23] = play2;
                    }
                    else if (omega.test[16] == empty)
                    {
                        omega.test[16] = play2;
                    }
                    else if (omega.test[9] == empty)
                    {
                        omega.test[9] = play2;
                    }
                }
            }
            else if (omega.test[38] != empty)
            {
                if ((omega.test[31] == empty && omega.test[24] == empty && omega.test[17] == empty && omega.test[10] == empty) ||
                (omega.test[31] == play2 && omega.test[24] == empty && omega.test[17] == empty && omega.test[10] == empty) ||
                (omega.test[31] == empty && omega.test[24] == play2 && omega.test[17] == empty && omega.test[10] == empty) ||
                (omega.test[31] == empty && omega.test[24] == empty && omega.test[17] == play2 && omega.test[10] == empty) ||
                (omega.test[31] == empty && omega.test[24] == empty && omega.test[17] == empty && omega.test[10] == play2) ||
                (omega.test[31] == play2 && omega.test[24] == play2 && omega.test[17] == empty && omega.test[10] == empty) ||
                (omega.test[31] == play2 && omega.test[24] == empty && omega.test[17] == play2 && omega.test[10] == empty) ||
                (omega.test[31] == play2 && omega.test[24] == empty && omega.test[17] == empty && omega.test[10] == play2) ||
                (omega.test[31] == empty && omega.test[24] == play2 && omega.test[17] == play2 && omega.test[10] == empty) ||
                (omega.test[31] == empty && omega.test[24] == play2 && omega.test[17] == empty && omega.test[10] == play2) ||
                (omega.test[31] == empty && omega.test[24] == empty && omega.test[17] == play2 && omega.test[10] == play2) ||
                (omega.test[31] == play2 && omega.test[24] == play2 && omega.test[17] == play2 && omega.test[10] == empty) ||
                (omega.test[31] == play2 && omega.test[24] == play2 && omega.test[17] == empty && omega.test[10] == play2) ||
                (omega.test[31] == empty && omega.test[24] == play2 && omega.test[17] == play2 && omega.test[10] == play2))
                {
                    if (omega.test[31] == empty)
                    {
                        omega.test[31] = play2;
                    }
                    else if (omega.test[24] == empty)
                    {
                        omega.test[24] = play2;
                    }
                    else if (omega.test[17] == empty)
                    {
                        omega.test[17] = play2;
                    }
                    else if (omega.test[10] == empty)
                    {
                        omega.test[10] = play2;
                    }
                }
            }
            else if (omega.test[39] != empty)
            {
                if ((omega.test[32] == empty && omega.test[25] == empty && omega.test[18] == empty && omega.test[11] == empty) ||
                (omega.test[32] == play2 && omega.test[25] == empty && omega.test[18] == empty && omega.test[11] == empty) ||
                (omega.test[32] == empty && omega.test[25] == play2 && omega.test[18] == empty && omega.test[11] == empty) ||
                (omega.test[32] == empty && omega.test[25] == empty && omega.test[18] == play2 && omega.test[11] == empty) ||
                (omega.test[32] == empty && omega.test[25] == empty && omega.test[18] == empty && omega.test[11] == play2) ||
                (omega.test[32] == play2 && omega.test[25] == play2 && omega.test[18] == empty && omega.test[11] == empty) ||
                (omega.test[32] == play2 && omega.test[25] == empty && omega.test[18] == play2 && omega.test[11] == empty) ||
                (omega.test[32] == play2 && omega.test[25] == empty && omega.test[18] == empty && omega.test[11] == play2) ||
                (omega.test[32] == empty && omega.test[25] == play2 && omega.test[18] == play2 && omega.test[11] == empty) ||
                (omega.test[32] == empty && omega.test[25] == play2 && omega.test[18] == empty && omega.test[11] == play2) ||
                (omega.test[32] == empty && omega.test[25] == empty && omega.test[18] == play2 && omega.test[11] == play2) ||
                (omega.test[32] == play2 && omega.test[25] == play2 && omega.test[18] == play2 && omega.test[11] == empty) ||
                (omega.test[32] == play2 && omega.test[25] == play2 && omega.test[18] == empty && omega.test[11] == play2) ||
                (omega.test[32] == empty && omega.test[25] == play2 && omega.test[18] == play2 && omega.test[11] == play2))
                {
                    if (omega.test[32] == empty)
                    {
                        omega.test[32] = play2;
                    }
                    else if (omega.test[25] == empty)
                    {
                        omega.test[25] = play2;
                    }
                    else if (omega.test[18] == empty)
                    {
                        omega.test[18] = play2;
                    }
                    else if (omega.test[11] == empty)
                    {
                        omega.test[11] = play2;
                    }
                }
            }
            else if (omega.test[40] != empty)
            {
                if ((omega.test[33] == empty && omega.test[26] == empty && omega.test[19] == empty && omega.test[12] == empty) ||
                (omega.test[33] == play2 && omega.test[26] == empty && omega.test[19] == empty && omega.test[12] == empty) ||
                (omega.test[33] == empty && omega.test[26] == play2 && omega.test[19] == empty && omega.test[12] == empty) ||
                (omega.test[33] == empty && omega.test[26] == empty && omega.test[19] == play2 && omega.test[12] == empty) ||
                (omega.test[33] == empty && omega.test[26] == empty && omega.test[19] == empty && omega.test[12] == play2) ||
                (omega.test[33] == play2 && omega.test[26] == play2 && omega.test[19] == empty && omega.test[12] == empty) ||
                (omega.test[33] == play2 && omega.test[26] == empty && omega.test[19] == play2 && omega.test[12] == empty) ||
                (omega.test[33] == play2 && omega.test[26] == empty && omega.test[19] == empty && omega.test[12] == play2) ||
                (omega.test[33] == empty && omega.test[26] == play2 && omega.test[19] == play2 && omega.test[12] == empty) ||
                (omega.test[33] == empty && omega.test[26] == play2 && omega.test[19] == empty && omega.test[12] == play2) ||
                (omega.test[33] == empty && omega.test[26] == empty && omega.test[19] == play2 && omega.test[12] == play2) ||
                (omega.test[33] == play2 && omega.test[26] == play2 && omega.test[19] == play2 && omega.test[12] == empty) ||
                (omega.test[33] == play2 && omega.test[26] == play2 && omega.test[19] == empty && omega.test[12] == play2) ||
                (omega.test[33] == empty && omega.test[26] == play2 && omega.test[19] == play2 && omega.test[12] == play2))
                {
                    if (omega.test[33] == empty)
                    {
                        omega.test[33] = play2;
                    }
                    else if (omega.test[26] == empty)
                    {
                        omega.test[26] = play2;
                    }
                    else if (omega.test[19] == empty)
                    {
                        omega.test[19] = play2;
                    }
                    else if (omega.test[12] == empty)
                    {
                        omega.test[12] = play2;
                    }
                }
            }
            else if (omega.test[41] != empty)
            {
                if ((omega.test[34] == empty && omega.test[27] == empty && omega.test[20] == empty && omega.test[13] == empty) ||
                (omega.test[34] == play2 && omega.test[27] == empty && omega.test[20] == empty && omega.test[13] == empty) ||
                (omega.test[34] == empty && omega.test[27] == play2 && omega.test[20] == empty && omega.test[13] == empty) ||
                (omega.test[34] == empty && omega.test[27] == empty && omega.test[20] == play2 && omega.test[13] == empty) ||
                (omega.test[34] == empty && omega.test[27] == empty && omega.test[20] == empty && omega.test[13] == play2) ||
                (omega.test[34] == play2 && omega.test[27] == play2 && omega.test[20] == empty && omega.test[13] == empty) ||
                (omega.test[34] == play2 && omega.test[27] == empty && omega.test[20] == play2 && omega.test[13] == empty) ||
                (omega.test[34] == play2 && omega.test[27] == empty && omega.test[20] == empty && omega.test[13] == play2) ||
                (omega.test[34] == empty && omega.test[27] == play2 && omega.test[20] == play2 && omega.test[13] == empty) ||
                (omega.test[34] == empty && omega.test[27] == play2 && omega.test[20] == empty && omega.test[13] == play2) ||
                (omega.test[34] == empty && omega.test[27] == empty && omega.test[20] == play2 && omega.test[13] == play2) ||
                (omega.test[34] == play2 && omega.test[27] == play2 && omega.test[20] == play2 && omega.test[13] == empty) ||
                (omega.test[34] == play2 && omega.test[27] == play2 && omega.test[20] == empty && omega.test[13] == play2) ||
                (omega.test[34] == empty && omega.test[27] == play2 && omega.test[20] == play2 && omega.test[13] == play2))
                {
                    if (omega.test[34] == empty)
                    {
                        omega.test[34] = play2;
                    }
                    else if (omega.test[27] == empty)
                    {
                        omega.test[27] = play2;
                    }
                    else if (omega.test[20] == empty)
                    {
                        omega.test[20] = play2;
                    }
                    else if (omega.test[13] == empty)
                    {
                        omega.test[13] = play2;
                    }
                }
            }
            Blocker(omega);
        }

        public void Blocker(Board omega)
        {
            //blocking bottom row
            if ((omega.test[35] == play1 && omega.test[36] == play1 && omega.test[37] == play1) ||
                (omega.test[36] == play1 && omega.test[37] == play1 && omega.test[38] == play1) ||
                (omega.test[35] == play1 && omega.test[36] == play1 && omega.test[38] == play1) ||
                (omega.test[35] == play1 && omega.test[37] == play1 && omega.test[38] == play1))
            {
                if (omega.test[35] == empty)
                {
                    omega.test[35] = play2;
                }
                else if (omega.test[36] == empty)
                {
                    omega.test[36] = play2;
                }
                else if (omega.test[37] == empty)
                {
                    omega.test[37] = play2;
                }
                else if (omega.test[38] == empty)
                {
                    omega.test[38] = play2;
                }
            }
            else if ((omega.test[38] == play1 && omega.test[39] == play1 && omega.test[40] == play1) ||
                (omega.test[39] == play1 && omega.test[40] == play1 && omega.test[41] == play1) ||
                (omega.test[38] == play1 && omega.test[39] == play1 && omega.test[41] == play1) ||
                (omega.test[38] == play1 && omega.test[40] == play1 && omega.test[41] == play1))
            {
                if (omega.test[38] == empty)
                {
                    omega.test[38] = play2;
                }
                else if (omega.test[39] == empty)
                {
                    omega.test[39] = play2;
                }
                else if (omega.test[40] == empty)
                {
                    omega.test[40] = play2;
                }
                else if (omega.test[41] == empty)
                {
                    omega.test[41] = play2;
                }
            }
            else if ((omega.test[36] == play1 && omega.test[37] == play1 && omega.test[38] == play1) ||
                (omega.test[37] == play1 && omega.test[38] == play1 && omega.test[39] == play1) ||
                (omega.test[36] == play1 && omega.test[37] == play1 && omega.test[39] == play1) ||
                (omega.test[36] == play1 && omega.test[38] == play1 && omega.test[39] == play1))
            {
                if (omega.test[36] == empty)
                {
                    omega.test[36] = play2;
                }
                else if (omega.test[37] == empty)
                {
                    omega.test[37] = play2;
                }
                else if (omega.test[38] == empty)
                {
                    omega.test[38] = play2;
                }
                else if (omega.test[39] == empty)
                {
                    omega.test[39] = play2;
                }
            }
            else if ((omega.test[37] == play1 && omega.test[38] == play1 && omega.test[39] == play1) ||
                (omega.test[38] == play1 && omega.test[39] == play1 && omega.test[40] == play1) ||
                (omega.test[37] == play1 && omega.test[38] == play1 && omega.test[40] == play1) ||
                (omega.test[37] == play1 && omega.test[39] == play1 && omega.test[40] == play1))
            {
                if (omega.test[37] == empty)
                {
                    omega.test[37] = play2;
                }
                else if (omega.test[38] == empty)
                {
                    omega.test[38] = play2;
                }
                else if (omega.test[39] == empty)
                {
                    omega.test[39] = play2;
                }
                else if (omega.test[40] == empty)
                {
                    omega.test[40] = play2;
                }
            }
            //blocking vertical
            else if ((omega.test[35] == play1 && omega.test[28] == play1 && omega.test[21] == play1) ||
                (omega.test[28] == play1 && omega.test[21] == play1 && omega.test[14] == play1) ||
                (omega.test[35] == play1 && omega.test[28] == play1 && omega.test[14] == play1) ||
                (omega.test[35] == play1 && omega.test[21] == play1 && omega.test[14] == play1))
            {
                if (omega.test[35] == empty)
                {
                    omega.test[35] = play2;
                }
                else if (omega.test[28] == empty)
                {
                    omega.test[28] = play2;
                }
                else if (omega.test[21] == empty)
                {
                    omega.test[21] = play2;
                }
                else if (omega.test[14] == empty)
                {
                    omega.test[14] = play2;
                }
            }
            else if ((omega.test[36] == play1 && omega.test[29] == play1 && omega.test[22] == play1) ||
                (omega.test[29] == play1 && omega.test[22] == play1 && omega.test[15] == play1) ||
                (omega.test[36] == play1 && omega.test[29] == play1 && omega.test[15] == play1) ||
                (omega.test[36] == play1 && omega.test[22] == play1 && omega.test[15] == play1))
            {
                if (omega.test[36] == empty)
                {
                    omega.test[36] = play2;
                }
                else if (omega.test[29] == empty)
                {
                    omega.test[29] = play2;
                }
                else if (omega.test[22] == empty)
                {
                    omega.test[22] = play2;
                }
                else if (omega.test[15] == empty)
                {
                    omega.test[15] = play2;
                }
            }
            else if ((omega.test[37] == play1 && omega.test[30] == play1 && omega.test[23] == play1) ||
                (omega.test[30] == play1 && omega.test[23] == play1 && omega.test[16] == play1) ||
                (omega.test[37] == play1 && omega.test[30] == play1 && omega.test[16] == play1) ||
                (omega.test[37] == play1 && omega.test[23] == play1 && omega.test[16] == play1))
            {
                if (omega.test[37] == empty)
                {
                    omega.test[37] = play2;
                }
                else if (omega.test[30] == empty)
                {
                    omega.test[30] = play2;
                }
                else if (omega.test[23] == empty)
                {
                    omega.test[23] = play2;
                }
                else if (omega.test[16] == empty)
                {
                    omega.test[16] = play2;
                }
            }
            else if ((omega.test[38] == play1 && omega.test[31] == play1 && omega.test[24] == play1) ||
                (omega.test[31] == play1 && omega.test[24] == play1 && omega.test[17] == play1) ||
                (omega.test[38] == play1 && omega.test[31] == play1 && omega.test[17] == play1) ||
                (omega.test[38] == play1 && omega.test[24] == play1 && omega.test[17] == play1))
            {
                if (omega.test[38] == empty)
                {
                    omega.test[38] = play2;
                }
                else if (omega.test[31] == empty)
                {
                    omega.test[31] = play2;
                }
                else if (omega.test[24] == empty)
                {
                    omega.test[24] = play2;
                }
                else if (omega.test[17] == empty)
                {
                    omega.test[17] = play2;
                }
            }
            else if ((omega.test[39] == play1 && omega.test[32] == play1 && omega.test[25] == play1) ||
                (omega.test[32] == play1 && omega.test[25] == play1 && omega.test[18] == play1) ||
                (omega.test[39] == play1 && omega.test[32] == play1 && omega.test[18] == play1) ||
                (omega.test[39] == play1 && omega.test[25] == play1 && omega.test[18] == play1))
            {
                if (omega.test[39] == empty)
                {
                    omega.test[39] = play2;
                }
                else if (omega.test[32] == empty)
                {
                    omega.test[32] = play2;
                }
                else if (omega.test[25] == empty)
                {
                    omega.test[25] = play2;
                }
                else if (omega.test[18] == empty)
                {
                    omega.test[18] = play2;
                }
            }
            else if ((omega.test[40] == play1 && omega.test[33] == play1 && omega.test[26] == play1) ||
                (omega.test[33] == play1 && omega.test[26] == play1 && omega.test[19] == play1) ||
                (omega.test[40] == play1 && omega.test[33] == play1 && omega.test[19] == play1) ||
                (omega.test[40] == play1 && omega.test[26] == play1 && omega.test[19] == play1))
            {
                if (omega.test[40] == empty)
                {
                    omega.test[40] = play2;
                }
                else if (omega.test[33] == empty)
                {
                    omega.test[33] = play2;
                }
                else if (omega.test[26] == empty)
                {
                    omega.test[26] = play2;
                }
                else if (omega.test[19] == empty)
                {
                    omega.test[19] = play2;
                }
            }
            else if ((omega.test[41] == play1 && omega.test[34] == play1 && omega.test[27] == play1) ||
                (omega.test[34] == play1 && omega.test[27] == play1 && omega.test[20] == play1) ||
                (omega.test[41] == play1 && omega.test[34] == play1 && omega.test[20] == play1) ||
                (omega.test[41] == play1 && omega.test[27] == play1 && omega.test[20] == play1))
            {
                if (omega.test[41] == empty)
                {
                    omega.test[41] = play2;
                }
                else if (omega.test[34] == empty)
                {
                    omega.test[34] = play2;
                }
                else if (omega.test[27] == empty)
                {
                    omega.test[27] = play2;
                }
                else if (omega.test[20] == empty)
                {
                    omega.test[20] = play2;
                }
            }
        }
    }
}
