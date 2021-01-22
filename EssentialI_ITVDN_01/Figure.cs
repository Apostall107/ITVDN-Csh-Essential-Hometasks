using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_01
{
    class Figure
    {
        Point[] point;
        string type;

        public Figure(Point A, Point B, Point C)
        {
            point = new Point[3];
            point[0] = A;
            point[1] = B;
            point[2] = C;
            type = "triangle";
        }

        public Figure(Point A, Point B, Point C,Point D) 
        {
            point = new Point[4];
            point[0] = A;
            point[1] = B;
            point[2] = C;
            point[3] = D;
            type = "square";
        }

        public Figure(Point A, Point B, Point C,Point D,Point F) 
        {
            point = new Point[5];
            point[0] = A;
            point[1] = B;
            point[2] = C;
            point[3] = D;
            point[4] = F;
            type = "pentagon";
        }


        private double LengthSide(Point A, Point B) 
        {
            
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
            
        }

        
        public void PerimeterCalculator() 
        {
            double sum = 0;
            for (int i = 0; i < point.Length; i++)
            {
                
                sum += LengthSide(point[i % point.Length], point[(i + 1) % point.Length]); ;
            }
            Console.WriteLine("{0} Perimeter = {1}",type,sum);
            Console.WriteLine(new string('-', 30));
        }

    }
}
