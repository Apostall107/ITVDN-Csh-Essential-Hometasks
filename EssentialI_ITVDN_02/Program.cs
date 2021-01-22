using System;

namespace EssentialI_ITVDN_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new string('-', 30));

            new Converter(27.7253, 33.6600, 0.3354).UAN_To_EUR(100);
            new Converter(27.7253, 33.6600, 0.3354).UAN_To_RUB(100);
            new Converter(27.7253, 33.6600, 0.3354).UAN_To_USD(100);
            new Converter(27.7253, 33.6600, 0.3354).USD_To_UAN(100);
            new Converter(27.7253, 33.6600, 0.3354).RUB_To_UAN(100);
            new Converter(27.7253, 33.6600, 0.3354).EUR_To_UAN(100);

            Console.WriteLine(new string('-', 30));

            int baseSal = 1000;
            int taxRate = 22;

            new Employee("Hryn", "Oleksandr").ShowCountSal(baseSal, 2, "Director", taxRate);

            new Employee("Vasilinchuk", "Yudjin").ShowCountSal(baseSal, 2, "putana", taxRate);

            new Employee("neVasilinchuk", "neYudjin").ShowCountSal(baseSal, 2, "Homeless", taxRate);

            Console.WriteLine(new string('-', 30));

            double VAT = 20;

            new Invoice(0, "Vasilinchuk Yudjin", "PROGRAMIST").ShowPrices("SSD", 100, VAT);
            new Invoice(80085, "neVasilinchuk neYudjin", "putana").ShowPrices("Super SSD", 3, VAT);
            new Invoice(777, "Azino Kazinovitch","AK-47").ShowPrices("Definetely not one more SSD",1,VAT);


        
            Console.ReadKey();
        }
    }
}
