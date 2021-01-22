using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_16.Ex2
{
    class Ex2Pr
    {
        public static void Show()
        {
            ExDeviderV2.Ex2();

            Block a = new Block(0, 1, 2, 3);
            Block b = new Block(4, 5, 6, 7);
            Block c = new Block(0, 1, 2, 3);


            Console.WriteLine("a == b : {0}", a.Equals(b));
            Console.WriteLine("a == c : {0}", a.Equals(c));

        }


    }
}
