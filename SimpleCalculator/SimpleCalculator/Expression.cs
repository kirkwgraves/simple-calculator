using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {        
       
        public object[] Parse(string input_expression, EvalStack eval_stack)
        {
            // Remove spaces from user input expression
            string user_expression = input_expression.Replace(" ", "");
            
            // Create char array of all possible valid constant keys
            char[] constant_values = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            // Identify operator's index in string
            int operatorIndex = user_expression.IndexOfAny(new char[] { '+', '-', '*', '/', '%', '=' }, 1);
 
            if (operatorIndex == -1)
            {
            // If no operator is found, throw exception alerting user that operator is needed
                throw new ArgumentException("You need an operator!");
            }
            
            // Store the operator in the local variable (oper) using its index from IndexOfAny method above
            char oper;
            oper = user_expression[operatorIndex];
            // Isolate terms of expression in string array using Split method with oper as delimiter
            string[] parsedTerms = user_expression.Split(oper);
           
            if (oper == '=')
            {
                // Get the index of the constant in the input string
                int constantIndex = user_expression.IndexOfAny(constant_values);
                
                if (constantIndex == -1)
                {
                    throw new ArgumentException("You didn't enter a single letter value (e.g., 'A', 'B', 'C', etc) for your constant!");
                }
                char constantKey = (char)parsedTerms[0][0];
                constantKey = char.ToUpper(constantKey);
                int constantValue;
                bool success = int.TryParse(parsedTerms[1], out constantValue);
                //int constantValue = (int)user_expression[2];

                object[] constant_expression = { constantKey, oper, constantValue };
                eval_stack.SetConstant(constant_expression);
                return constant_expression; /* This STOPS the method - it's a return statment (duh).
                Constant expression has been parsed and constant is set. */
            }

            else
            {

                // Check that string array with expression terms contains at least two elements
                if (parsedTerms.Length != 2 || parsedTerms[0].Equals("") || parsedTerms[1].Equals(""))
                {
                    throw new ArgumentException("You haven't entered the correct number of terms.");
                }

                // Declare the terms
                int num1, num2;

                bool success = int.TryParse(parsedTerms[0], out num1);

                if (!success)
                {
                    char retrieved_const = char.ToUpper(parsedTerms[0][0]);
                    num1 = eval_stack.GetConstant(retrieved_const);
                }

                success = int.TryParse(parsedTerms[1], out num2);
                if (!success)
                {
                    char retrieved_const2 = char.ToUpper(parsedTerms[0][0]);
                    num2 = eval_stack.GetConstant(retrieved_const2);
                }
               

                object[] parsed_expression = { num1, oper, num2 };
                eval_stack.lastq = parsed_expression;
                return parsed_expression;

            }

        }
    }
}          