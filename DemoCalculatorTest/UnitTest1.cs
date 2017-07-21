using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoCalculator;

namespace DemoCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionTest()
        {
            Calculator calc = new Calculator();

            var Number1 = 7;
            var Number2 = 11;
            var ExpectedValue = Number1 + Number2;

            var ActualValue = calc.Addition(Number1, Number2);

            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Addition_NegativeNumberTest()
        {
            Calculator calc = new Calculator();

            var Number1 = -7;
            var Number2 = 1;
            var ExpectedValue = Number1 + Number2;

            var ActualValue = calc.Addition(Number1, Number2);
        }

        [TestMethod]
        public void DivisionTest()
        {
            Calculator calc = new Calculator();

            var Number1 = 3;
            var Number2 = 7;
            var ExpectedValue = Number1 / Number2;

            var ActualValue = calc.Division(Number1, Number2);

            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Division_With_Zero_Test()
        {
            Calculator calc = new Calculator();

            var Number1 = 0;
            var Number2 = 7;
            var ExpectedValue = Number1 / Number2;

            var ActualValue = calc.Division(Number1, Number2);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Calculator calc = new Calculator();

            var Number1 = 2;
            var Number2 = 5;
            var ExpectedValue = Number1 * Number2;

            var ActualValue = calc.Multiplication(Number1, Number2);

            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Multiplication_By_Zero_Test()
        {
            Calculator calc = new Calculator();

            var Number1 = 0;
            var Number2 = 5;
            var ExpectedValue = Number1 * Number2;

            var ActualValue = calc.Multiplication(Number1, Number2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Multiplication_Number_GreaterThan_12_Test()
        {
            Calculator calc = new Calculator();

            var Number1 = 15;
            var Number2 = 40;
            var ExpectedValue = Number1 * Number2;

            var ActualValue = calc.Multiplication(Number1, Number2);
        }
    }
}
