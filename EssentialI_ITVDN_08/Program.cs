using System;


namespace EssentialI_ITVDN_08
{
    class Program
    {
        static void Main(string[] args)
        {
            ExDeviderV2.AdditionalEx();

            int year=2021;
            int mounth=2;
            int day=5;

            new DaysTillBD(year,mounth,day);

            ExDeviderV2.Ex2();

            ColorTextPrinter.Print("This is my colored text. ", 3);
            ColorTextPrinter.Print("This is my colored text. ", 2);
            ColorTextPrinter.Print("This is my colored text. ", 1);
            ColorTextPrinter.Print("This is my colored text. ", 4);
            ColorTextPrinter.Print("This is my colored text. ", 5);

            ExDeviderV2.Ex3();
            //    Manager = 195,
            //Developer = 200,
            //Accountant = 192,
            //Secretary = 192,
            //Cleaner = 192


            if (Accauntant.AskForBonus(Post.Accountant, 222))
            {
                Console.WriteLine("Give premium!");
            }
            else
            {
                Console.WriteLine("No premium allowed!");
            }



        }
    }
}
