using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class EvalStack
    {
        Terminal user_term = new Terminal();
        Dictionary<char, int> constant = new Dictionary<char, int>();
        public object[] lastq { get; set; }
        public double last { get; set; }

        public void SetConstant(object[] constant_exp)
        {
            if (constant_exp.Contains('='))
            {
                constant.Add((char)constant_exp[0], (int)constant_exp[2]);
            }
            else
            {
                throw new Exception();
            }
        }

        public int GetConstant(char constantKey)
        {
            int value;
            constant.TryGetValue(constantKey, out value);
            return value;
        }

    }
}
