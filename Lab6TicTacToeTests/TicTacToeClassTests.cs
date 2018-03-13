using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab6TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6TicTacToe.Tests
{
    [TestClass()]
    public class TicTacToeClassTests
    {
        [TestMethod()]
        public void CreateBoardTest()
        {
            TicTacToe board = new TicTacToe();
            board.CreateBoard();

            Assert.AreEqual(9, board.newBoard.Length);
        }

        [TestMethod()]
        public void CurrentPlayerX()
        {
            TicTacToe board = new TicTacToe();
            //Player 1 = X

            Assert.AreEqual(1, board.CurrentPlayer());

        }

        [TestMethod()]
        public void CurrentPlayerO()
        {
            TicTacToe board = new TicTacToe();
            //Player 2 = O
            board.switchPlayer();
            Assert.AreEqual(2, board.CurrentPlayer());

        }

        [TestMethod()]
        public void playerXMarker()
        {
            TicTacToe board = new TicTacToe();
            board.CreateBoard();
            board.MakeMove(0);

            Assert.AreEqual(1, board.newBoard[0]);
        }

        [TestMethod()]
        public void playerOMarker()
        {
            TicTacToe board = new TicTacToe();
            board.CreateBoard();
            board.switchPlayer();
            board.MakeMove(0);
            Assert.AreEqual(2, board.newBoard[0]);
        }

        [TestMethod()]
        public void playerMarkerUnoccupied()
        {
            TicTacToe board = new TicTacToe();
            board.CreateBoard();
            //Space no occupied, false = space is not in use
            Assert.AreEqual(false, board.SpaceInUse(0));
        }
    }
}