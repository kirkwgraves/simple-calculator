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
        
        public void AcceptUserExpression()
        {
            Console.Write("[" + counter + "]> ");
            Expression user_expression = new Expression();
            Evaluate exp_to_eval = new Evaluate();

            while (true)
            {
                string user_input = Console.ReadLine();
                object[] parsed_exprssion = user_expression.ExtractTerms(user_input);
                double exp_output = exp_to_eval.EvaluateExpression(parsed_exprssion);
                Console.WriteLine("   =  " + exp_output);
                counter++;
                Console.Write("[" + counter + "] > ");
            }
        }
    }
}
