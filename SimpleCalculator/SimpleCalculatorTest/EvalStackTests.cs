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
            my_stack.lastq = new object[] { 8, '*', 9};
             
            // Act
            object[] actual = my_stack.lastq;
            object[] expected = { 8, '*', 9 };

            // Assert
            CollectionAssert.AreEqual(actual, expected);
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

        [TestMethod]
        public void EvalStackProveICanGetAndSetConstant()
        {
            // Arrange
            EvalStack my_stack = new EvalStack();
            object[] constant_exp = { 'A', '=', 2 };
            char constantKey = 'A';

            // Act
            my_stack.SetConstant(constant_exp);
            int actual = my_stack.GetConstant(constantKey);
            int expected = 2;

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
