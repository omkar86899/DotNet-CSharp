using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeApp.Model;

namespace TicTacToeUnitTestApp
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void WhenPassingMarkXToPlayerConsturctorMarkShouldReturnX()
        {
            //Arrange
            Player player = new Player(Mark.X, "omkar");
            Mark expectedMark = Mark.X;

            //Act
            Mark actualMark = player.Mark;

            //Assert
            Assert.AreEqual(expectedMark, actualMark);
        }

        [TestMethod]
        public void WhenPassingMarkOToPlayerConsturctorMarkShouldReturnO()
        {
            //Arrange
            Player player = new Player(Mark.O, "omkar");
            Mark expectedMark = Mark.O;

            //Act
            Mark actualMark = player.Mark;

            //Assert
            Assert.AreEqual(expectedMark, actualMark);
        }

        [TestMethod]
        public void WhenPassingNameOmkarToPlayerConsturctorNameShouldReturnOmkar()
        {
            //Arrange
            Player player = new Player(Mark.O, "omkar");
            String expectedName = "omkar";

            //Act
            String actualName = player.Name;

            //Assert
            Assert.AreEqual(expectedName, actualName);
        }
    }
}
