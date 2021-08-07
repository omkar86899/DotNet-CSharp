using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeApp.Model;

namespace TicTacToeTestApp
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void IfAllBoardIsFullThenPlayShouldReturnDraw()
        {
            //Arrange
            Player p1, p2;
            p1 = new Player(Mark.O, "omkar");
            p2 = new Player(Mark.X, "sagar");
            IBoard board = new Board();
            IResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Game game = new Game(p1,p2,resultAnalyzer,board);
            Result exepectedResult = Result.Draw;

            //Act
            Result actualResult = Result.Processing;
            for(int i = 0; i < 9; i++)
            {
                actualResult = game.Play(i);
            }

            //Assert
            Assert.AreEqual(exepectedResult, actualResult);
        }

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

        public void IfBoardStatusIsNotFullAndNoWinningScenarioHappensThenPlayShouldReturnProcessing()
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
            Result actualResult = game.Play(0);

            //Assert
            Assert.AreEqual(exepectedResult, actualResult);
        }
    }
}
