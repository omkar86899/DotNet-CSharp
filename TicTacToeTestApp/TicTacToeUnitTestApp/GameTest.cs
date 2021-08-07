using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeApp.Model;

namespace TicTacToeUnitTestApp
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void IfAllBoardIsFullAndNoWinningSenarioHappensThenPlayShouldReturnDraw()
        {
            //Arrange
            Player p1, p2;
            p1 = new Player(Mark.O, "omkar");
            p2 = new Player(Mark.X, "sagar");
            IBoard board = new Board();
            IResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Game game = new Game(p1, p2, resultAnalyzer, board);
            Result exepectedResult = Result.Draw;

            //Act
            Result actualResult;
            game.Play(0);
            game.Play(8);
            game.Play(2);
            game.Play(6);
            game.Play(7);
            game.Play(1);
            game.Play(3);
            game.Play(4);
            actualResult = game.Play(5);

            //Assert
            Assert.AreEqual(exepectedResult, actualResult);
        }

        [TestMethod]
        public void IfAllCellsOfBoardInRowHavingSameMarkThenPlayShouldReturnWin()
        {
            //Arrange
            Player p1, p2;
            p1 = new Player(Mark.O, "omkar");
            p2 = new Player(Mark.X, "sagar");
            IBoard board = new Board();
            IResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Game game = new Game(p1, p2, resultAnalyzer, board);
            Result exepectedResult = Result.Win;

            //Act
            game.Play(0);
            game.Play(3);
            game.Play(1);
            game.Play(4);
            Result actualResult = game.Play(2);

            //Assert
            Assert.AreEqual(exepectedResult, actualResult);
        }

        [TestMethod]
        public void IfBoardStatusIsNotFullAndNoWinningScenarioHappensThenPlayShouldReturnProcessing()
        {
            //Arrange
            Player p1, p2;
            p1 = new Player(Mark.O, "omkar");
            p2 = new Player(Mark.X, "sagar");
            IBoard board = new Board();
            IResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Game game = new Game(p1, p2, resultAnalyzer, board);
            Result exepectedResult = Result.Processing;

            //Act
            Result actualResult = game.Play(0);

            //Assert
            Assert.AreEqual(exepectedResult, actualResult);
        }
    }
}
