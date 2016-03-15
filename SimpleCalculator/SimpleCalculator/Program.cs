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

            while (true)
            {
                Console.Write(user_term.PromptInitialUserInput());
                string user_input = Console.ReadLine();
                object[] parsed_expression = user_expression.ExtractTerms(user_input);
                if (parsed_expression.Length < 2)
                {
                    char constant_key = (char)parsed_expression[0];

                    // Why am I getting zero here?
                    Console.WriteLine(constant_key);
                    //int constant_val = eval_stack.GetConstant(constant_key);
                   // Console.WriteLine(user_term.DisplayExpressionResult(constant_val));
                }
                else if (parsed_expression[0] is char && parsed_expression.Length > 1)
                {
                    eval_stack.SetConstant(parsed_expression);
                    user_term.counter++;
                }
                else
                {
                    double expression_output = math_ops.EvaluateExpression(parsed_expression, eval_stack);
                    Console.WriteLine(user_term.DisplayExpressionResult(expression_output));
                }
            } 

        }
    }
}
