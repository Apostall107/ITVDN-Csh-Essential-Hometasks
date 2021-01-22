using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_17.AdditionalEx
{
    class AdditionaExPr
    {

        public static void Show()
        {
            ExDeviderV2.AdditionalEx();

            Console.WriteLine(Calculator.Add("1",2));
            Console.WriteLine(Calculator.Div(1,3));
            Console.WriteLine(Calculator.Div(1,0));
            Console.WriteLine(Calculator.Mult(2,2.5));
            Console.WriteLine(Calculator.Sub(2 ,  10));



        }




    }
}
