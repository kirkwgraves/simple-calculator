using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTest
{
    [TestClass]
    public class ExpressionTests
    {

        [TestMethod]
        public void ExpressionEnsureICanCreateInstance()
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
            string expected = my_expression.RemoveSpacesFromExpression();
            string actual = "1+5";

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExpressionProveICanExtractTerms()
        {
            // Arrange
            Expression my_expression = new Expression();

            // Act 
            Parse parsedExpression = my_expression.ExtractTerms("5 + 9");
            int expectedNum1 = parsedExpression.Num1;
            int actualNum1 = 5;

            int expectedNum2 = parsedExpression.Num2;
            int actualNum2 = 9;

            char expectedOperator = parsedExpression.Operate;
            char actualOperator = '+';

            // Assert
            Assert.AreEqual(expectedNum1, actualNum1);
            Assert.AreEqual(expectedNum2, actualNum2);
            Assert.AreEqual(expectedOperator, actualOperator);
        }

    }
}

        
  