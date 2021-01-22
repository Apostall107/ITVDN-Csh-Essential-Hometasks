using System;


namespace EssentialI_ITVDN_01
{

    class Program
    {
        static void Main(string[] args)
        {
            double a = 200;
                double b = 300.25;
            Console.WriteLine("Rectangle({0}Х{1}) Area is : {2} ",a,b, new Rectangle(a, b).AreaCalculator());
            Console.WriteLine("Rectangle({0}Х{1}) Perimeter is : {2} ",a,b, new Rectangle(a, b).PerimeterCalculator());

            ////////////////////////////////-------EX2------/////////////////////////////////////

           new Book ("its my book`s title",
                "its content of my book",
                "I`m author of this book").ShowBook();

            /////////////////////////////////--------EX3-------////////////////////////////////


            Point A = new Point(2, 4);
            Point B = new Point(2, 3);
            Point C = new Point(1, 1);
            Point D = new Point(5, 4);
            Point F = new Point(8, 3);

            Figure rectangle = new Figure(A, B, C);
            Figure square = new Figure(B, C, D, F);
            Figure pentagon = new Figure(A, B, C, D, F);


            rectangle.PerimeterCalculator();
            square.PerimeterCalculator();
            pentagon.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
