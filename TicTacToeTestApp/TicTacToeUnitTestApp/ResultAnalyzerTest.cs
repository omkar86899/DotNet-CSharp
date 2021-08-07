using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TicTacToeApp.Model;

namespace TicTacToeUnitTestApp
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void IfAllBoardIsFullAndNoWinningScenarioThenGameResultShouldReturnDraw()
        {
            //Arrange
            Player p1, p2;
            p1 = new Player(Mark.O, "omkar");
            p2 = new Player(Mark.X, "sagar");
            IBoard board = new Board();
            IResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Result exepectedResult = Result.Draw;

            //Act
            List<Cell> gameBoard = board.Board;
            gameBoard[0].CellMark = Mark.O;
            gameBoard[1].CellMark = Mark.O;
            gameBoard[2].CellMark = Mark.X;
            gameBoard[3].CellMark = Mark.X;
            gameBoard[4].CellMark = Mark.X;
            gameBoard[5].CellMark = Mark.O;
            gameBoard[6].CellMark = Mark.O;
            gameBoard[7].CellMark = Mark.O;
            gameBoard[8].CellMark = Mark.X;
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
            for (int i = 0; i < 3; i++)
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
            for (int i = 0; i < 9; i += 3)
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
