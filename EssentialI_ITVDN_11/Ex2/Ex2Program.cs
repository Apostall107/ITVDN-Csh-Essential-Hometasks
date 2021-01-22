using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_11
{
    static class Ex2Program
    {
        public static void Show()
        {
            ExDeviderV2.Ex2();

            Console.WriteLine("CArCollection:");
            var park = new CarCollection<string>();

            park.AddCar("Жигули", new DateTime(1985, 12, 5));
            park.AddCar("Тойота", new DateTime(2000, 4, 7));
            park.AddCar("Форд", new DateTime(2005, 5, 3));
            park.AddCar("Мерседес", new DateTime(2003, 11, 3));

            Console.WriteLine(park.ToString());

            park.CarCount();

            Console.WriteLine("Enter the index of car:");
            string stroka = Console.ReadLine();

            if (string.IsNullOrEmpty(stroka))
                Console.WriteLine("Nothing was entered! ");
            else
            {
                int nomer = Convert.ToInt32(stroka);
                Console.WriteLine(park[nomer - 1]);
            }


            ExDeviderV2.Line();
        }




    }
}
