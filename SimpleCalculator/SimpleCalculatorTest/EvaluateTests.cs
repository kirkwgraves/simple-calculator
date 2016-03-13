using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void EvaluateProveICanCreateInstance()
        {
            // Arrange
            Evaluate my_eval_expression = new Evaluate();

            // Assert
            Assert.IsNotNull(my_eval_expression);
        }

        [TestMethod]
        public void EvaluateProveICanAddTerms()
        {
            // Arrange
            Evaluate addition_exp = new Evaluate();
            EvalStack last_values = new EvalStack();
            object[] test_expression = { 5, '+', 6 };

            // Act
            double actual = addition_exp.EvaluateExpression(test_expression, last_values);
            double expected = 11;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluateProveICanSubtractTerms()
        {
            // Arrange
            Evaluate subtraction_exp = new Evaluate();
            EvalStack last_values = new EvalStack();
            object[] test_expression = { 9, '-', 3 };

            // Act
            double actual = subtraction_exp.EvaluateExpression(test_expression, last_values);
            double expected = 6;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluateProveICanMultiplyTerms()
        {
            // Arrange
            Evaluate multiplication_exp = new Evaluate();
            EvalStack last_values = new EvalStack();
            object[] test_expression = { 5, '*', 8 };

            // Act
            double actual = multiplication_exp.EvaluateExpression(test_expression, last_values);
            double expected = 40;

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluateProveICanDivideTerms()
        {
            // Arrange
            Evaluate division_exp = new Evaluate();
            EvalStack last_values = new EvalStack();
            object[] test_expression = { 15, '/', 3 };

            // Act
            double actual = division_exp.EvaluateExpression(test_expression, last_values);
            double expected = 5;

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluateProveICanDivideUnevenly()
        {
            // Arrange 
            Evaluate division_exp = new Evaluate();
            EvalStack last_values = new EvalStack();
            object[] test_expression = { 15, '/', 4 };

            // Act
            double actual = division_exp.EvaluateExpression(test_expression, last_values);
            double expected = 3.75;

            // Assert
            Assert.AreEqual(actual, expected);
        }
    
        [TestMethod]
        public void EvaluateProveICanGetModulo()
        {
            // Arrange 
            Evaluate modulus_exp = new Evaluate();
            EvalStack last_values = new EvalStack();
            object[] test_expression = { 10, '%', 3 };

            // Act
            double actual = modulus_exp.EvaluateExpression(test_expression, last_values);
            double expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
