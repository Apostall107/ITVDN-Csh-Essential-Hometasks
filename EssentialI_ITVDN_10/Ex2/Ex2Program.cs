using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_10
{
    static class Ex2Program
    {
        static public void Dialog_Show()
        {
            ExDeviderV2.Ex2();

            Console.WriteLine("Enter the array size!");
            string str = Console.ReadLine();
            int size = (string.IsNullOrEmpty(str)) ? 0 : Convert.ToInt32(str);

          
            var list = new MyList<int>();
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                list.Add(rnd.Next(0, 100));
            }
            ExDeviderV2.Line();
            Console.Write($"array contains {list.Count} elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(" "+list[i]);
            }
            ExDeviderV2.Line();

            Console.WriteLine("Enter the value to search.");
            str =  Console.ReadLine();

            if (list.Contains(Convert.ToInt32(str)))
            {
                Console.WriteLine("match found!");
            }
            else
            {
                Console.WriteLine("No matches found!");
            }

            ExDeviderV2.Line();
            list.Clear();
            Console.WriteLine("Array cleared");
            Console.Write($"array cintains {list.Count} elements:");


            ExDeviderV2.DoubleLine();
        }


    }
}
