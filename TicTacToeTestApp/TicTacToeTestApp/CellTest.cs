using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeApp.Model;

namespace TicTacToeTestApp
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void InitiallyCellMarkShouldReturnEMPTY ()
        {
            //Arrange
            Cell cell = new Cell();
            Mark expectedMark = Mark.EMPTY;

            //Act
            Mark actualMark = cell.CellMark;

            //Assert
            Assert.AreEqual(expectedMark, actualMark);
        }

        [TestMethod]
        public void IfCellIsMarkedAsXThenCellMarkShouldReturnX()
        {
            //Arrange
            Cell cell = new Cell();
            Mark expectedMark = Mark.X;

            //Act
            cell.CellMark = Mark.X;
            Mark actualMark = cell.CellMark;

            //Assert
            Assert.AreEqual(expectedMark, actualMark);
        }

        [TestMethod]
        public void IfCellIsMarkedAsOThenCellMarkShouldReturnO()
        {
            //Arrange
            Cell cell = new Cell();
            Mark expectedMark = Mark.O;

            //Act
            cell.CellMark = Mark.O;
            Mark actualMark = cell.CellMark;

            //Assert
            Assert.AreEqual(expectedMark, actualMark);
        }
    }
}
