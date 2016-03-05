using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTest
{
    [TestClass]
    public class ExpressionTests
    {

        [TestMethod]
        public void ExpressionProveICanCreateInstance()
        {
            // Arrange 
            Expression my_expression = new Expression();

            // Assert
            Assert.IsNotNull(my_expression);

        }

        [TestMethod]
        public void ExpressionProveICanRemoveSpacesFromExpression()
        {
            // Arrange
            Expression my_expression = new Expression();

            // Act
            string actual = my_expression.RemoveSpacesFromExpression();
            string expected = "1+5";

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExpressionProveICanExtractTerms()
        {
            // Arrange
            Expression my_expression = new Expression();

            // Act 
            object[] actual = my_expression.ExtractTerms("5 + 9");
            object[] expected = { 5, '+', 9 }; 
 
            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}

        
  