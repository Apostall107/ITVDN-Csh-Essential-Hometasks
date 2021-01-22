using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EssentialI_ITVDN_14
{
    static class StaticClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[list.Count()];

            int i = 0;

            foreach (T item in list)
            {
                array[i] = item;
                i++;
            }

            return array;
        }
    }
    class Program
    {

        public static IEnumerable Try()
        {
            int i = 0;
            while (i++ < 10)
                yield return $"yield: {i}";

        }
        static void Main(string[] args)
        {
            ExDeviderV2.AdditionalEx();

            foreach (string el in Try())
                Console.WriteLine(el);

            ExDeviderV2.Ex2();//------------------------------------------------------------------------------------

            Ex2Program.ShowEx();

            ExDeviderV2.Ex3();//------------------------------------------------------------------------------------

            Ex3Program.ShowEx3();

            ExDeviderV2.Ex4();//------------------------------------------------------------------------------------

            MyList<int> list = new MyList<int>();

            for (int i = 0; i < 11; i++)
                list.Add(i);

            int[] arr = list.GetArray();

            foreach (int t in arr)
                Console.Write("{0}  ", t);
        }


    }
}
