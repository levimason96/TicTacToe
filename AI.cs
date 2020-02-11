using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TicTacToe
{
    class AI
    {
        public AI()
        {

        }

        public int getMove(char[] arr)
        {
            Random rand = new Random();
            int option = rand.Next(1, 10);

            if (isValid(arr, option))
            {
                Thread.Sleep(500);
            }
            else
            {
                while (!(isValid(arr, option)))
                {
                    option = rand.Next(1, 10);
                }

                Thread.Sleep(250);
            }

            return option;
        }

        public static bool isValid(char[] arr, int move)
        {
            bool validity = false;
            if (arr[move] != 'X' && arr[move] != 'O')
            {
                validity = true;
            }

            return validity;
        }
    }
}
