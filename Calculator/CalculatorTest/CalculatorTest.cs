using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTwoNumbersOk()
        {
            //arrange
            Calculator.Calculator myCalculator = new Calculator.Calculator();
            int firstOperand = 3;
            int secondOperand = 4;
            int expectedResult = 7;
            //act
            int result = myCalculator.Add(firstOperand, secondOperand);
            //assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void DivideTwoNumbersOk()
        {
            //arrange
            Calculator.Calculator myCalculator = new Calculator.Calculator();
            int firstOperand = 3;
            int secondOperand = 3;
            int expectedResult = 1;
            //act
            int result = myCalculator.Divide(firstOperand, secondOperand);
            //assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroError()
        {
            //arrange
            Calculator.Calculator myCalculator = new Calculator.Calculator();
            int firstOperand = 3;
            int secondOperand = 0;
            //act
            int result = myCalculator.Divide(firstOperand, secondOperand);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MultiplyTwoNumbersOk()
        {
            //arrange
            Calculator.Calculator myCalculator = new Calculator.Calculator();
            int firstOperand = 3;
            int secondOperand = 0;
            int expectedResult = 0;
            //act
            int result = myCalculator.Divide(firstOperand, secondOperand);
        }

    }
}
