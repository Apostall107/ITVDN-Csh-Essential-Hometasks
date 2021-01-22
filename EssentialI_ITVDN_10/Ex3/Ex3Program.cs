using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_10
{
    static class Ex3Program
    {

        static public void Show()
        {
            ExDeviderV2.Ex3();

            var dictionary = new MyDictionary<string, string>();

            Console.Write("Enter the quantity of words you want to add to dictionaty: ");
            int times = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < times; t++)
                dictionary.Add( "table", "стол");


            dictionary.ShowDict();



            ExDeviderV2.DoubleLine();



        }

    }
}
