using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EssentialI_ITVDN_13
{
    static class AdditionalExProgram
    {
        static int counter = 0;
        // Метод, который планируется выполнять в отдельном потоке.
        static void WriteSecond()
        {

            if (counter < 3)
            {
                for (int i = 0; i < 3; i++)
                {

                    Console.WriteLine("iteration {1}  --- code потока {0}: ", Thread.CurrentThread.GetHashCode(), i);
                    new Thread(
                     () =>
                     {
                         WriteSecond();
                     }).Start();
                    counter++;
                }
            }
            Console.WriteLine("code потока {0}: закончил!!!!!!!", Thread.CurrentThread.GetHashCode());
        }

        public static void ShowAdditionalEx()
        {
            ExDeviderV2.AdditionalEx();

            new Thread(
                () =>
                {
                    WriteSecond();
                }).Start();

            Thread.Sleep(500);


        }
    }
}
