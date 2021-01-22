using System;
using Dictionary;

namespace EssentialI_ITVDN_18
{
    class Program
    {
        static void Main(string[] args)
        {
            ExDeviderV2.Ex1();
            //using Dictionary;
            MyDictionary<dynamic, string> dictionary = new MyDictionary<dynamic, string>();
            dictionary.Add("abc1", "абв1");
            dictionary.Add("abc2", "абв2");
            dictionary.Add("abc3", "абв3");
            dictionary.Add("abc4", "абв4");
            dictionary.Add("abc5", "абв5");
            dictionary.Add("abc6", "абв6");
            dictionary.Add("abc7", "абв7");



            foreach (string item in dictionary)
                Console.WriteLine(item);



            ExDeviderV2.Ex2();


        }
    }
}
