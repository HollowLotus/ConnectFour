﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            board.Draw();
            Console.ReadLine();
        }
    }
}
