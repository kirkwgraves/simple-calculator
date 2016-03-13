using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Terminal
    {
        public int counter { get; set; }

        public Terminal()
        {
            counter = 0;
        }

        public string ReturnLastExpression(object[] lastq)
        {
            string returned_exp = lastq.ToString();
            return returned_exp;
        }

        public void AcceptUserExpression()
        {
            Console.Write("[" + counter + "]> ");
            Expression user_expression = new Expression();
            Evaluate exp_to_eval = new Evaluate();
            EvalStack last_values = new EvalStack();



            while (true)
            {
                string user_input = Console.ReadLine();
                object[] parsed_exprssion = user_expression.ExtractTerms(user_input);
                double exp_output = exp_to_eval.EvaluateExpression(parsed_exprssion, last_values);
                Console.WriteLine("   =  " + exp_output);
                counter++;
                Console.WriteLine("Your last expression was: " + this.ReturnLastExpression(parsed_exprssion));
                Console.Write("[" + counter + "] > ");
            } // End while statement
        } // End AcceptUserExpression()
    } // End Terminal class definition
}
    

