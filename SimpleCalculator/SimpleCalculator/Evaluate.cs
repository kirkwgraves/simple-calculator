using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {

        public double EvaluateExpression (object[] exp, EvalStack last_values)
        {
            last_values.lastq = exp;
            char the_operator = (char)exp[1];
            int num1 = (int)exp[0];
            int num2 = (int)exp[2];

            if (the_operator == '+')
            {
                Addition add_exp = new Addition();
                last_values.last = add_exp.Add(num1, num2);
            }
            else if (the_operator == '-')
            {
                Subtraction subt_exp = new Subtraction();
                last_values.last = subt_exp.Subtract(num1, num2);
            }
            else if (the_operator == '*')
            {
                Multiplication multip_exp = new Multiplication();
                last_values.last = multip_exp.Multiply(num1, num2);
            }
            else if (the_operator == '/')
            {
                Division division_exp = new Division();
                last_values.last = division_exp.Divide(num1, num2);
            }
            else if (the_operator == '%')
            {
                Modulus modulo_exp = new Modulus();
                last_values.last = modulo_exp.Modulo(num1, num2);
            }
                return last_values.last; 
                throw new InvalidOperationException("You didn't enter a valid operator!");
        }

    }
}
