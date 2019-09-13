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
       

    }
}
