using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_11
{
    static class Ex3Program
    {

        static public void Show()
        {
            ExDeviderV2.Ex3();

            var dictionary = new MyDictionary<string, string>();

            
            dictionary.Add("table", "стол");
            dictionary.Add("apple", "яблоко");
            dictionary.Add("sun", "солнце");
            dictionary.Add("pencil", "карандаш");
            dictionary.Add("cap", "чашка");
            dictionary.Add("tea", "чай");

            
            dictionary.ShowDict();
            ExDeviderV2.Line();
            Console.WriteLine("Введите номер записи в словаре:");
            string str = Console.ReadLine();
            ExDeviderV2.Line();
            if (string.IsNullOrEmpty(str))
                Console.WriteLine("Вы не ввели номер записив словаре");
            else
            {
                int nomer = Convert.ToInt32(str);
                Console.WriteLine(dictionary[nomer - 1]);
            }
            ExDeviderV2.Line();
            Console.WriteLine("Введите значение для поиска");
            string p = Console.ReadLine();
            Console.WriteLine(dictionary.Contains(p));

            ExDeviderV2.Line();
            Console.WriteLine("Введите значение для поиска");
             p = Console.ReadLine();
            Console.WriteLine(dictionary.Contains(p));

            ExDeviderV2.Line();


        }

    }
}
