using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
       
        virtual public string RemoveSpacesFromExpression()
        {
            string input_expression = "1 + 5";
            input_expression = input_expression.Replace(" ", "");
            return input_expression;
        }

        virtual public Parse ExtractTerms(string input_expression)
        {
            Console.WriteLine("Please enter an expression.");
            // Remove spaces from user input expression
            string user_expression = input_expression.Replace(" ", "");
            // Identify operator's index in string
            int operatorIndex = user_expression.IndexOfAny(new char[] { '+', '-', '*', '/', '%' });

            // If no operator is found, throw exception alerting user that operator is needed
            if (operatorIndex == -1)
            {
                throw new InvalidOperationException("You need an operator!");
            }

            // Store the operator in the local variable (oper) using its index from IndexOfAny method above
            char oper = user_expression[operatorIndex];
            // Isolate terms of expression in string array using Split method with oper as delimiter
            string[] parsedTerms = user_expression.Split(oper);

            // Check that string array with expression terms contains at least two elements
            if (parsedTerms.Length != 2 || parsedTerms[0].Equals("") || parsedTerms[1].Equals(""))
            {
                throw new InvalidOperationException("You haven't entered the correct number of terms.");
            }

            // Create new instance of Parse class, which contains properties for our terms and operator
            Parse parsed_expression = new Parse();
            parsed_expression.Operate = oper;
            parsed_expression.Num1 = Convert.ToInt32(parsedTerms[0]);
            parsed_expression.Num2 = Convert.ToInt32(parsedTerms[1]);
       
            return parsed_expression;
        }
    }
}          