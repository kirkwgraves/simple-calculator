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
            EvalStack eval_stack = new EvalStack();
            double result = 44;

            // Act
            string actual = my_term.DisplayExpressionResult(result);
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
            my_evalStack.lastq = new object[] { 4, '*', 6 };

            // Act
            string actual = my_term.ReturnLastExpression(my_evalStack);
            string expected = "   4*6";

            // Assert
            Assert.AreEqual(actual, expected);
        }

        //[TestMethod]
        //public void RunCalculator()
        //{
        //    Expression expression = new Expression();
        //    Evaluate evaluate = new Evaluate();
        //    EvalStack eval_stack = new EvalStack();
        //    Terminal terminal = new Terminal();
        //    object[] test_object = { 'T', '=', 6 };
        //    eval_stack.SetConstant(test_object);
        //    string user_input = "T + 6";
        //    RunCalculator(expression, evaluate, eval_stack, terminal, user_input);
        //}

        //public static void RunCalculator(Expression expression, Evaluate evaluate, EvalStack eval_stack, Terminal terminal, string user_input)
        //{

        //    Console.Write(terminal.PromptInitialUserInput());
        //    object[] parsed_expression = expression.Parse(user_input, eval_stack);
        //    CollectionAssert.AreEqual(parsed_expression, new object[] { "T", "+", 6 });
        //    string test_parse = (string)parsed_expression[0];
           
        //    if (eval_stack.constant.ContainsKey((char)test_parse[0]))
        //    {
        //        Console.WriteLine(eval_stack.GetConstant((char)test_parse[0]));
        //        Assert.AreEqual((eval_stack.GetConstant((char)test_parse[0])), 6);
        //    }
        //    terminal.counter++;

        //}
    }
}
        
