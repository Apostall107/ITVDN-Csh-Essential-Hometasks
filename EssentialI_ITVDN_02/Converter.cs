using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_02
{
    class Converter
    {
        double usd, eur, rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void UAN_To_USD(int value) { Console.WriteLine("{0} UAN_To_USD = {1}",value,(value / this.usd)); }
        public void UAN_To_EUR(int value) { Console.WriteLine("{0} UAN_To_EUR = {1}",value,(value / this.eur)); }
        public void UAN_To_RUB(int value) { Console.WriteLine("{0} UAN_To_RUB = {1}",value,(value / this.rub)); }
                           
                          
        public void USD_To_UAN(int value) { Console.WriteLine("{0} UAN_To_EUR = {1}", value, (value * this.usd)); }
        public void EUR_To_UAN(int value) { Console.WriteLine("{0} UAN_To_USD = {1}", value, (value * this.eur)); }
        public void RUB_To_UAN(int value) { Console.WriteLine("{0} UAN_To_RUB = {1}", value, (value *this.rub)); }

    }
}
