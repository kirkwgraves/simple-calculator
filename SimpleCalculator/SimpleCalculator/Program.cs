using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a simple arithmetic expression.");

            Terminal user_term = new Terminal();
            Expression user_expression = new Expression();
            Evaluate math_ops = new Evaluate();
            EvalStack eval_stack = new EvalStack();
            bool loop_runner = true;
            while (loop_runner)
            {
                Console.Write(user_term.PromptInitialUserInput());
                string user_input = Console.ReadLine();

                if (user_input == "lastq")
                {
                    Console.WriteLine(user_term.ReturnLastExpression(eval_stack));
                }
                else if (user_input == "last")
                {
                    Console.WriteLine(user_term.DisplayExpressionResult(eval_stack.last));    
                }
                else if (user_input == "exit" || user_input == "quit")
                {
                    Environment.Exit(0);
                }
                else if (user_input.Contains('='))
                {
                    object[] parsed_expression = user_expression.Parse(user_input, eval_stack);
                    user_term.counter++;
                }
                else
                {
                    object[] parsed_expression = user_expression.Parse(user_input, eval_stack);
                    double expression_output = math_ops.EvaluateExpression(parsed_expression, eval_stack);
                    user_term.counter++;
                    Console.WriteLine(user_term.DisplayExpressionResult(expression_output));
                }
                
            } 

        }
    }
}
