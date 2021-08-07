using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeApp.Model;
using System.Collections.Generic;

namespace TicTacToeUnitTestApp
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void BoardConstructorShouldinitializeBoardSizeTo3()
        {
            //Arrange
            IBoard board = new Board();
            int exepectedSize = 3;

            //Act
            int actualSize = board.Size;

            //Assert
            Assert.AreEqual(exepectedSize, actualSize);
        }

        [TestMethod]
        public void TotalNoOfCellsInBoardShouldBe9()
        {
            //Arrange
            IBoard board = new Board();
            int exepectedNoOfCells = 9;

            //Act
            int actualNoOfCells = 0;
            foreach (Cell cell in board.Board)
            {
                actualNoOfCells++;
            }

            //Assert
            Assert.AreEqual(exepectedNoOfCells, actualNoOfCells);
        }

        [TestMethod]
        public void InitiallyAllCellsShouldHaveMarkAsEmpty()
        {
            //Arrange
            IBoard board = new Board();
            List<Cell> exepectedListOfCell = new List<Cell>();
            for (int i = 0; i < 9; i++)
            {
                exepectedListOfCell.Add(new Cell());
            }

            //Act
            List<Cell> actualListOfCell = board.Board;

            //Assert
            for (int i = 0; i < 9; i++)
            {
                Assert.AreEqual(exepectedListOfCell[i].CellMark, actualListOfCell[i].CellMark);
            }
        }
    }
}
