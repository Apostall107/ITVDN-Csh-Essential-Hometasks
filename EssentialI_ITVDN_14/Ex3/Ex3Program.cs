using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_14
{
    class Ex3Program
    {
        public static void ShowEx3()
        {
            var dictionary = new MyDictionary<string, string>
            {
                { "стол", "table" },
                { "яблоко", "apple" },
                { "карандаш", "pencil" },
                { "солнце", "sun" },
                { "блокнот", "notepad" }
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            ExDeviderV2.Line();
            Console.WriteLine("Вторая запись в словаре:");
            Console.WriteLine(dictionary[1]);
            ExDeviderV2.Line();
            Console.WriteLine("Размер словаря:");
            Console.WriteLine(dictionary.Lenght + " слов");
            ExDeviderV2.Line();



        }
    }
}
