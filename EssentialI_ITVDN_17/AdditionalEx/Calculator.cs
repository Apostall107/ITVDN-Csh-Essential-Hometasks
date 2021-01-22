using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_17.AdditionalEx
{
    static class Calculator
    {

        public static dynamic Add(dynamic a , dynamic b)
        {
            return a + b;
        }
        public static dynamic Sub(dynamic a, dynamic b)
        {
            return a - b;
        }
        public static dynamic Div(dynamic a, dynamic b)
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "NaN";
            }

        }
        public static dynamic Mult(dynamic a, dynamic b)
        {
            return a * b;
        }

    }
}
