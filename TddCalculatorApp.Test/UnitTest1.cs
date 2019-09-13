using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddCalculatorApp.Library;

namespace TddCalculatorApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnPositiveOnPassingTwoPositiveNumbers()
        {
            Calculator calObj = new Calculator();
            int num1 = 3;
            int num2 = 4;
            int result;
            result = calObj.AddIntegers(num1, num2);

            Assert.AreEqual(7, result, "Testing two integers 3 and 2");
        }
        [TestMethod]
        public void ShouldReturnZeroOnPassingPairOfPositiveAndNegativeNumbers()
        {
            Calculator testObj = new Calculator();
            int num1 = -3;
            int num2 = +3;
            int result;
            result = testObj.AddIntegers(num1, num2);
            Assert.AreEqual(0, result, "Testing pair of integer identical positive and negative two integers");

        }

    }
}
