using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EssentialI_ITVDN_13
{

    public static class Ex2Prorgam
    {
       readonly static int X = Program.X,
            Y = Program.Y;


         public static void  Show()
        {
            Matrix matrix = null;
            for (int i = 0; i < X; i++)
            {
                matrix = new Matrix(i);
                new Thread(() => { matrix.Char_Stream_Drop(); }).Start();
            }



        }


    }


}