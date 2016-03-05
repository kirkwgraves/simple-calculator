using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {
        public double EvaluateExpression (object[] exp)
        {
            char the_operator = (char)exp[1];
            int num1 = (int)exp[0];
            int num2 = (int)exp[2];

            if (the_operator == '+')
            {

                Addition add_exp = new Addition();
                return add_exp.Add(num1, num2);
            }
            else if (the_operator == '-')
            {
                Subtraction subt_exp = new Subtraction();
                return subt_exp.Subtract(num1, num2);
            }
            else if (the_operator == '*')
            {
                Multiplication multip_exp = new Multiplication();
                return multip_exp.Multiply(num1, num2);
            }
            else if (the_operator == '/')
            {
                Division division_exp = new Division();
                return division_exp.Divide(num1, num2);
            }
            else if (the_operator == '%')
            {
                Modulus modulo_exp = new Modulus();
                return modulo_exp.Modulo(num1, num2);
            }
            throw new InvalidOperationException("You didn't enter a valid operator!");
        }

    }
}
