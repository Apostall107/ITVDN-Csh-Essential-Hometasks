using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_16.Ex3
{
    class Ex3Pr
    {

       static public void Show()
        {
            ExDeviderV2.Ex3();

            House original = new House();
            House clone = original.Clone() as House;

            Console.WriteLine("Первая проверка");

            Console.WriteLine(original);
            Console.WriteLine(clone);

            // Изменяем clone.x (при этом original.x не изменится)
            clone.Room = "your room";
            clone.Toilet = "your toilet";

            // Проверка.
            Console.WriteLine("Вторая проверка после изменения");
            Console.WriteLine(original);
            Console.WriteLine(clone);
        }



    }
}
