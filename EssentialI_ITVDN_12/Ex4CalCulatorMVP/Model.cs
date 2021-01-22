using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4CalCulatorMVP
{

    class Model
    {



        bool
        symbol_check = false;
        double A, B;
        string first_num, second_num,symbol;

        public void Clear()
        {
            symbol_check = false;
            

        }

        public string OperationCheck(string text,string operation)
        {
            symbol_check = true;
            symbol = operation;

            first_num = text;
            if (string.IsNullOrEmpty(first_num) == true)
                first_num = "0";


            return operation ;
        }
        public string Enter_Check(string text)
        {

            if (symbol_check == false)
              return  "0";
            second_num = text;
            if (string.IsNullOrEmpty(second_num) == true) 
                second_num = "0";

            return $"{first_num} {symbol} {second_num} = " + Do_Operation();

        }

        private string Do_Operation()
        {

             A = Convert.ToDouble(first_num);
             B = Convert.ToDouble(second_num);

            switch (symbol)
            {
                case "/":
                    return Div_operation();
                case "X":
                    return Mult_operation();
                case "+":
                    return Add_operation();
                case "-":
                    return Sub_operation();

                default:
                    return "0";

            }
        }

        #region Operations
        string Div_operation()
        {
            string str;
            return str = (B == 0 ) ? "NaN" : Convert.ToString(A / B);
        }
        string Mult_operation()
        {
            return Convert.ToString(A * B);
        }

        string Add_operation()
        {
            return Convert.ToString(A + B);
        }

        string Sub_operation()
        {
            return Convert.ToString(A - B);
        }
        #endregion


    }
}
