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
        public void TerminalProveICan()
        {

        }
    }
}
