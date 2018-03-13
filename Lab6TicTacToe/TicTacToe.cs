using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6TicTacToe
{
    public class TicTacToe
    {
        public int player = 1;
        public int[] newBoard = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public void CreateBoard()
        {
            newBoard = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        public void switchPlayer()
        {
            if (player == 1)
            {
                player = 2;
            }
            else if  (player == 2)
            {
                player = 1;
            }
            CurrentPlayer();
        }

        public int CurrentPlayer()
        {
            return player;
        }

        public void MakeMove(int space)
        {
            if (SpaceInUse(space) == true)
            {
                Console.WriteLine("Player cannot move here");
            }
            else
            {
                newBoard[space] = CurrentPlayer();
            }
        }

        public bool SpaceInUse(int i)
        {
            if (newBoard[i] != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}