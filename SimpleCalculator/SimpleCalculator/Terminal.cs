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

        public string PromptInitialUserInput()
        {
            return String.Format("[{0}]> ", counter);
        }

        public string DisplayExpressionResult(double result)
        {
            string result_as_string = String.Format("  ={0}", result);
            counter++;
            return result_as_string;
        }

        public string ReturnLastExpression(EvalStack eval_stack)
        {
            return String.Format("{0}{1}{2}", eval_stack.lastq);
        }
    }
}
   