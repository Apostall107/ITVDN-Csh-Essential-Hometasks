using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_16
{

    

    struct Point
    {
        int x, y, z;

        public int X 
        { 
            get 
            {
                return x;
            }
        }
        public int Y 
        { 
            get
            {
                return y;
            }
        }
        public int Z 
        {
            get
            {
                return z;
            }
        }
        public static Point operator +(Point one, Point two)
        {

            return new Point
                (one.X + two.X,
                one.Y + two.Y,
                one.Z + two.Z);
        }


        public Point(int  X, int Y , int Z)
        {   
            this.x = X;
            this.y = Y;
            this.z = Z;
        }
    
    }

}
