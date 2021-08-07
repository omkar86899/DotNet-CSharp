using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLib;

namespace CalculatorTestProject
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void IsEvenShouldReturnTrueWhen2isPassed()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int inputValue = 2;
            bool expectedValue = true;

            //Act
            bool actualValue = calculator.CheckEven(inputValue);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void IsEvenShouldReturnTrueWhen3isPassed()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int inputValue = 3;
            bool expectedValue = false;

            //Act
            bool actualValue = calculator.CheckEven(inputValue);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void IsEvenShouldReturnFalseWhenNegativeNumberisPassed()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int inputValue = -1;
            bool expectedValue = false;

            //Act
            bool actualValue = calculator.CheckEven(inputValue);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void IsEvenShouldReturnTrueWhen0isPassed()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int inputValue = 0;
            bool expectedValue = true;

            //Act
            bool actualValue = calculator.CheckEven(inputValue);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void CheckPrimeShouldReturnTrueWhen2isPassed()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int inputValue = 2;
            bool expectedValue = true;

            //Act
            bool actualValue = calculator.CheckPrime(inputValue);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void CheckPrimeShouldReturnFalseWhen10isPassed()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int inputValue = 10;
            bool expectedValue = false;

            //Act
            bool actualValue = calculator.CheckPrime(inputValue);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void CheckPrimeShouldReturnFalseWhenNegativeNumberisPassed()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int inputValue = -1;
            bool expectedValue = false;

            //Act
            bool actualValue = calculator.CheckPrime(inputValue);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void CheckPrimeShouldReturnTrueWhen0isPassed()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int inputValue = 0;
            bool expectedValue = true;

            //Act
            bool actualValue = calculator.CheckPrime(inputValue);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
