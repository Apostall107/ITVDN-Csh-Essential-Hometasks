using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_15
{
    class Calculator
    {
        public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        public int Sub(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        public int Mul(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        public int? Div(int operand1, int operand2)
        {
            
            try
            {
                return operand1 / operand2;
            }
            catch(Exception e)
            {
                Console.WriteLine($"error: {e.Message}");
                return null;

            }
        }
    }
}
