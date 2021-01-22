using System;
using System.Threading;
using System.Collections;



namespace EssentialI_ITVDN_13
{

    public class Program
    {


        public static int X = 60,
                   Y = 30;


        static void Main(string[] args)
        {
            AdditionalExProgram.ShowAdditionalEx();



           Console.WriteLine("Press any button to clean scr and start new Ex!");
           Console.ReadKey();
           Console.Clear();


            Console.SetWindowSize(X+2, Y+8);

            Ex2Prorgam.Show();

        }


    }
}
