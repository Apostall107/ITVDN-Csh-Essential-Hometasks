using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_03
{
    class Printer
    {
        public void Print(string value)
        {
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class PrinterRed : Printer
    {
        public void Print(string value) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
        }
    }

    class PrinterBlue : Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
        }
    }



}

