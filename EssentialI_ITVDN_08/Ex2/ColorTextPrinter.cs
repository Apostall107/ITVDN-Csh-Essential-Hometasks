using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_08
{
    enum Colors
    {
        Grey = 0,
        Red,
        Blue,
        Green,
        Yellow

    }
    static class ColorTextPrinter
    {
      
       public static void Print(string stroka, int color)
        {
            ChooseColor(color);
            Console.WriteLine(stroka);
            Console.ResetColor();
        }

        static void ChooseColor(int color)
        {
            switch (color)
            {
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.WriteLine("There is no duch a color! Defauld color will be chosen!");
                    break;
            }

        }

    }
}
