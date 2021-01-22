using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_17.Ex3
{
    class Ex3Pr
    {


        public static void Show()
        {

            ExDeviderV2.Ex3();


            dynamic dict = new Dictionary<dynamic, dynamic>
            {
                { new { Key = "table" }, new { Value = "стол" } },
                { new { Key = "apple" }, new { Value = "яблоко" } },
                { new { Key = "pen" }, new { Value = "ручка" } },
                { new { Key = "pencil" }, new { Value = "карандаш" } },
                { new { Key = "task" }, new { Value = "задание" } },
                { new { Key = "key" }, new { Value = "ключ" } },
                { new { Key = "customer" }, new { Value = "покупатель" } },
                { new { Key = "ship" }, new { Value = "корабль" } },
                { new { Key = "car" }, new { Value = "машина" } },
                { new { Key = "cap" }, new { Value = "чашка" } },
                {"-------------","----------" },
                { "table2", "стол2" },
                { "apple2", "яблоко2" },
                { "pen2", "ручка2" },
                { "penci2l", "карандаш2" },
                { "task2", "задание2" },
                { "key2", "ключ2" },
                { "customer2", "покупатель2" },
                { "ship2", "корабль2" },
                { "car2", "машина2" },
                { "cap2", "чашка2" }
            };



            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            }
        }
}
}
