using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_10
{
    static class Ex4Program
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var temp = new T[list.Count];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = list[i];
            }

            return temp;
        }

        static public void Show()
        {
            ExDeviderV2.Ex4();

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
            Console.Write($"GetArray extension method used.\n array contains {list.Count} elements:");
            int[] f = list.GetArray();   // использование расширяющего метода

            for (int i = 0; i < f.Length; i++)
            {
                Console.Write("{0} ", f[i]);
            }

            ExDeviderV2.Line();
        }
    }
}
