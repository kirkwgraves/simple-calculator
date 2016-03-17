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
        public void ExpressionProveICanParse()
        {
            // Arrange
            Expression my_expression = new Expression();
            EvalStack eval_stack = new EvalStack();

            // Act 
            object[] actual = my_expression.Parse("5 + 9", eval_stack);
            object[] expected = { 5, '+', 9 }; 
 
             // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExpressionProveICanParseConstantExp()
        {
            // Arrange
            Expression my_expression = new Expression();
            EvalStack eval_stack = new EvalStack();
            object[] test_expression = { 'M', '=', 5 };

            // Act
            object[] actual = my_expression.Parse("M = 5", eval_stack);
            object[] expected = test_expression;

            // Assert
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ExpressionProveICanDoMathWithConst()
        {
            // Arrange 
            Expression my_expression = new Expression();
            EvalStack eval_stack = new EvalStack();
            Evaluate evaluate = new Evaluate();
            eval_stack.SetConstant(new object[] { 'M', '=', 8 });
            string test_expression = "M * 4";
            object[] test_object = my_expression.Parse(test_expression, eval_stack);

            //Act
            double actual = evaluate.EvaluateExpression(test_object, eval_stack);
            double expected = 32;

            // Assert
            Assert.AreEqual(actual, expected);
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpressionProveICanHandleBadExpression1()
        {
            // Arrange
            Expression my_expression = new Expression(); ;
            EvalStack eval_stack = new EvalStack();

            // Act
            my_expression.Parse("6 +", eval_stack);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpressionProveICanHandleBadExpression2()
        {
            // Arrange 
            Expression my_expression = new Expression();
            EvalStack eval_stack = new EvalStack();

            // Act
            my_expression.Parse(" + 6", eval_stack);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpressionProveICanHandleBadExpression3()
        {
            // Arrange
            Expression my_expression = new Expression();
            EvalStack eval_stack = new EvalStack();

            // Act
            my_expression.Parse("5", eval_stack);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpressionProveICanHandleBadExpressionNoOper()
        {
            // Arrange 
            Expression my_expression = new Expression();
            EvalStack eval_stack = new EvalStack();

            // Act 
            my_expression.Parse("8 9", eval_stack);
        }



    }
}

        
  