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

            Terminal exp_to_display = new Terminal();
            exp_to_display.AcceptUserExpression();
        }
    }
}
