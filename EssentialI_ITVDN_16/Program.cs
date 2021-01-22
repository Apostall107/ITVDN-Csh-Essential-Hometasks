using System;

namespace EssentialI_ITVDN_16
{
    class Program
    {


        static void Main(string[] args)
        {
            ExDeviderV2.AdditionalEx();//--------------------------------------------------------------------------------------------------------------------------

            Point test = new Point(1, 2, 3) + new Point(3, 3, 3);

            Console.WriteLine(test.X + " " + test.Y + " " + test.Z);

            //--------------------------------------------------------------------------------------------------------------------------

             Ex2.Ex2Pr.Show();

            Ex3.Ex3Pr.Show();

            Ex4.Ex4Pr.Show();

        }
    }
}
