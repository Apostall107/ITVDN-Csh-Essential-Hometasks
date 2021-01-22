using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_06
{
    static class Calculator
    {
        
            static public double Add(double a, double b)
            {
                return a + b;
            }

            static public double Sub(double a, double b)
            {
                return a - b;
            }

            static public double Mult(double a, double b)
            {
                if (a == 0 || b == 0)
                {
                    return 0;
                }
                return a * b;
            }

            static public double Div(double a, double b)
            {
                if (b == 0)
                {
                    return 0;
                }
                return a / b;
            }

       
    }
    
}