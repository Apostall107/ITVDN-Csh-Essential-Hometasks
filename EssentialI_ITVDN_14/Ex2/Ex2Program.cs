using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_14
{
    static class Ex2Program
    {
        public static void ShowEx()
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            Console.WriteLine("Длина массива = {0}", list.Count);

            foreach (int item in list)
                Console.Write("{0}  ", item);
        }
    }
}
