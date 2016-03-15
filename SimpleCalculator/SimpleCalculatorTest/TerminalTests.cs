using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTest
{
    [TestClass]
    public class TerminalTests
    {
        [TestMethod]
        public void TerminalProveICanCreateInstance()
        {
            // Arrange
            Terminal my_term = new Terminal();

            // Assert
            Assert.IsNotNull(my_term);
        }

        [TestMethod]
        public void TerminalProveICanPromptInitialUserInput()
        {
            // Arrange
            Terminal my_term = new Terminal();

            // Act
            string actual = my_term.PromptInitialUserInput();
            string expected = "[0]> ";

            // Assert 
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TerminalProveICanDisplayExpressionResult()
        {
            // Arrange
            Terminal my_term = new Terminal();
            double result = 44;

            // Act
            string actual = my_term.DisplayExpressionResult(44);
            string expected = "   = 44";

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TerminalProveICanReturnLastExpression()
        {
            // Arrange
            Terminal my_term = new Terminal();
            EvalStack my_evalStack = new EvalStack();
            my_evalStack.lastq = new object[] { 4, "*", 6 };
            
            // Act
            string actual = my_term.ReturnLastExpression(my_evalStack);
            string expected = "4*6";

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
