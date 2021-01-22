using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_01
{
    class Point
    {

        public int X, Y;
        public string point_str = "empty";

       public int Get_X()
        {

            return this.X;

        }
        public int Get_Y()
        {

            return this.Y;

        }
        public void Get_Point_Str()
        {

            Console.WriteLine(this.point_str);

        }

        public Point(int x,int y)
        {

            this.X = x;
            this.Y = y;
        }

        public Point(int x, int y, string str)
        {
            this.X = x;
            this.Y = y;
            this.point_str = str;

        }


    }
}
