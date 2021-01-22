using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_16.Ex4
{
    class Ex4Pr
    {

        public static void Show()
        {
            ExDeviderV2.Ex4();

            MyDate date1 = new MyDate(DateTime.Now);
            Console.WriteLine(date1.ToString());

            MyDate date2 = new MyDate(new DateTime(2022, 12, 4));
            Console.WriteLine(date2.ToString());

            Console.WriteLine("date1 - date2 = " +  ((date1 - date2)));

            int days = 20;

            Console.WriteLine($"date + {days} days =  {date1 + days}" );

             

        }


    }
}
