using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTest
{
    [TestClass]
    public class EvalStackTests
    {
        [TestMethod]
        public void EvalStackProveICanCreateInstance()
        {
            // Arrange
            EvalStack my_stack = new EvalStack();

            // Assert
            Assert.IsNotNull(my_stack);
        }


        [TestMethod]
        public void EvalStackProveICanAccessLastQ()
        {
            // Arrange 
            EvalStack my_stack = new EvalStack();
            my_stack.lastq = "8 * 9";

            // Act
            string actual = my_stack.lastq;
            string expected = "8 * 9";

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void EvalStackProveICanAccessLast()
        {
            // Arrange
            EvalStack my_stack = new EvalStack();
            my_stack.last = 48;

            // Act
            double actual = my_stack.last;
            double expected = 48;

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
