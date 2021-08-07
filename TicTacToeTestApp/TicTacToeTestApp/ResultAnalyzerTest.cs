using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TicTacToeApp.Model;

namespace TicTacToeTestApp
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void IfAllBoardIsFullThenGameResultShouldReturnDraw()
        {
            //Arrange
            Player p1, p2;
            p1 = new Player(Mark.O, "omkar");
            p2 = new Player(Mark.X, "sagar");
            IBoard board = new Board();
            IResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Result exepectedResult = Result.Draw;

            //Act
            foreach(Cell cell in board.Board)
            {
                cell.CellMark = Mark.O;
            }
            Result actualResult = resultAnalyzer.GameResult;

            //Assert
            Assert.AreEqual(exepectedResult, actualResult);
        }

        [TestMethod]
        public void IfHorizontalCellsOfBoardHavingSameMarkThenGameResultShouldReturnWin()
        {
            //Arrange
            Player p1, p2;
            p1 = new Player(Mark.O, "omkar");
            p2 = new Player(Mark.X, "sagar");
            IBoard board = new Board();
            IResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Result exepectedResult = Result.Win;

            //Act
            List<Cell> gameBoard = board.Board;
            for(int i = 0; i < 3; i++)
            {
                gameBoard[i].CellMark = Mark.X;
            }
            Result actualResult = resultAnalyzer.GameResult;

            //Assert
            Assert.AreEqual(exepectedResult, actualResult);
        }

        [TestMethod]
        public void IfVerticalCellsOfBoardHavingSameMarkThenGameResultShouldReturnWin()
        {
            //Arrange
            Player p1, p2;
            p1 = new Player(Mark.O, "omkar");
            p2 = new Player(Mark.X, "sagar");
            IBoard board = new Board();
            IResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Result exepectedResult = Result.Win;

            //Act
            List<Cell> gameBoard = board.Board;
            for (int i = 0; i < 9; i+=3)
            {
                gameBoard[i].CellMark = Mark.X;
            }
            Result actualResult = resultAnalyzer.GameResult;

            //Assert
            Assert.AreEqual(exepectedResult, actualResult);
        }

        [TestMethod]
        public void IfDiagonalCellsOfBoardHavingSameMarkThenGameResultShouldReturnWin()
        {
            //Arrange
            Player p1, p2;
            p1 = new Player(Mark.O, "omkar");
            p2 = new Player(Mark.X, "sagar");
            IBoard board = new Board();
            IResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Result exepectedResult = Result.Win;

            //Act
            List<Cell> gameBoard = board.Board;
            gameBoard[0].CellMark = Mark.X;
            gameBoard[4].CellMark = Mark.X;
            gameBoard[8].CellMark = Mark.X;
            Result actualResult = resultAnalyzer.GameResult;

            //Assert
            Assert.AreEqual(exepectedResult, actualResult);
        }


    }
}
