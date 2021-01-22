using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_13
{
    static class ExDeviderV2
    {
       /*  public ExDevider(string topic)
        {
            Console.Write(new string('=', 50));
            Console.Write("---{0}---", topic);
            Console.WriteLine(new string('=', 50));
        }*/

        static ExDeviderV2() 
        {
           
        }

        static public void Ex1()
        {
            Console.WriteLine();
            Console.Write(new string('=', 50));
            Console.Write("---EX1---");
            Console.WriteLine(new string('=', 50));
        }

        static public void Ex2()
        {
            Console.WriteLine();
            Console.Write(new string('=', 50));
            Console.Write("---EX2---");
            Console.WriteLine(new string('=', 50));
        }
        static public void Ex3()
        {
            Console.WriteLine();
            Console.Write(new string('=', 50));
            Console.Write("---EX3---");
            Console.WriteLine(new string('=', 50));
        }
        static public void Ex4()
        {
            Console.WriteLine();
            Console.Write(new string('=', 50));
            Console.Write("---EX4---");
            Console.WriteLine(new string('=', 50));
        }

        static public void Ex5()
        {
            Console.WriteLine();
            Console.Write(new string('=', 50));
            Console.Write("---EX5---");
            Console.WriteLine(new string('=', 50));
        }

        static public void AdditionalEx()
        {
            Console.WriteLine();
            Console.Write(new string('=', 50));
            Console.Write("---AdditionalEx---");
            Console.WriteLine(new string('=', 50));
        }

        static public void Line()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 100));
        }

        static public void DoubleLine()
        {
            Console.WriteLine();
            Console.WriteLine(new string('=', 100));
        }


        static public void DivideByTextExtended(this string text)
        {
            Console.WriteLine();
            Console.Write(new string('=', 50));
            Console.Write(text);
            Console.WriteLine(new string('=', 50));
        }


        static public string DivideByText(string text)
        {
            Console.WriteLine();
            Console.Write(new string('=', 50));
            Console.Write(text);
            Console.WriteLine(new string('=', 50));

            return "";
        }



    }
}
