using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {

        public string RemoveSpacesFromExpression()
        {
            string input_expression = "1 + 5";
            input_expression = input_expression.Replace(" ", "");
            return input_expression;
        }

        public object[] ExtractTerms(string input_expression)
        {
            EvalStack eval_stack = new EvalStack();
            // Remove spaces from user input expression
            string user_expression = input_expression.Replace(" ", "");
            
            // Create char array of all possible valid constant keys
            char[] constant_values = new char[] { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n', 'O', 'o', 'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u', 'V', 'v', 'W', 'w', 'X', 'x', 'Y', 'y', 'Z', 'z' };

            if (user_expression.Length == 1) 
            {
                int constant = eval_stack.GetConstant(user_expression[0]);
                object[] the_constant = { constant };
                return the_constant;
            }
            
            // Identify operator's index in string
            int operatorIndex = user_expression.IndexOfAny(new char[] { '+', '-', '*', '/', '%', '=' }, 1);
 
            // Store the operator in the local variable (oper) using its index from IndexOfAny method above
            char oper;
            oper = user_expression[operatorIndex];
           
            if (oper == '=')
            {
                // Get the index of the constant in the input string
                int constantIndex = user_expression.IndexOfAny(constant_values);
                
                if (constantIndex == -1)
                {
                    throw new ArgumentException("You didn't enter a single letter value (e.g., 'A', 'B', 'C', etc) for your constant!");
                }
                char constantKey = (char)user_expression[0];
                constantKey = Char.ToUpper(constantKey);
                int constantValue = (int)user_expression[2];
                return new object[] { constantKey, oper, constantValue };
            }

            // If no operator is found, throw exception alerting user that operator is needed
            else if (operatorIndex == -1)
            {
                throw new ArgumentException("You need an operator!");
            }

            else
            {
                // Isolate terms of expression in string array using Split method with oper as delimiter
                string[] parsedTerms = user_expression.Split(oper);

                // Check that string array with expression terms contains at least two elements
                if (parsedTerms.Length != 2 || parsedTerms[0].Equals("") || parsedTerms[1].Equals(""))
                {
                    throw new ArgumentException("You haven't entered the correct number of terms.");
                }

                // Declare the terms
                int num1, num2;
                try
                {
                    num1 = Convert.ToInt32(parsedTerms[0]);
                }
                catch (Exception)
                {
                    throw new ArgumentException("The first term is not an integer!");
                }
                try
                {
                    num2 = Convert.ToInt32(parsedTerms[1]);
                }
                catch (Exception)
                {
                    throw new ArgumentException("The second term is not an integer!");
                }


                object[] parsed_expression = { num1, oper, num2 };
                return parsed_expression;

            }

        }
    }
}          