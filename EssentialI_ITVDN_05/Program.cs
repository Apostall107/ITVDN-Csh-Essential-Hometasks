using System;

namespace EssentialI_ITVDN_05
{
    class Program
    {
        static void Main(string[] args)
        {
            new ExDevider("AdditionalEx");

            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["pen"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }


            new ExDevider("Ex2");

            Random rnd = new Random(new DateTime().Millisecond);

            int N = 24;
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = rnd.Next(1,100);
            }


            new MyArray(array, N).ShowArrayEx();


            new ExDevider("Ex3");

            MyMatrix matrix = new MyMatrix(10,10);

            matrix.ChangeSizeRaws(matrix,5);

            matrix.ChangeSizeColumns(matrix, -5);

            matrix.ChangeSizeColumns(matrix, 10);

            matrix.ChangeSizeColumns(matrix, -4);

            matrix.ChangeSizeColumns(matrix, 2);

            matrix.ChangeSizeColumns(matrix, -1);

            matrix.ChangeSizeColumns(matrix, 2);

            matrix.ShowPart(3, 3);

            new ExDevider("Ex4");


            Store st = new Store(3);

            st.AddArticle(new Article("Book", "MackMilan", 20), 0);
            st.AddArticle(new Article("Apple", "Delight", 5), 1);
            st.AddArticle(new Article("Coca-Cola", "Fozzy", 7), 2);


            
           
           Console.WriteLine( "\nsearch by index 1 => {0}\n" +
               "search by name \" Book\" => {1}\n"
               ,st.SearchByIndex(1),st.SearchByProductName("Book"));



            ExDeviderV2.DoubleLine();
            ExDeviderV2.DivideByText("EX with ans examples");
            ExDeviderV2.DoubleLine();
            ExDeviderV2.DivideByText("MyMatrixV2");

            MyMatrixV2 matrixV2 = new MyMatrixV2(10, 10);
            ExDeviderV2.DivideByText("array 10 x 10");
            matrixV2.Show();

            matrixV2.ChangeSize(15, 15);
            ExDeviderV2.DivideByText("changed array 15 x 15");
            matrixV2.Show();
            ExDeviderV2.DivideByText("array partly 5-10 x 5-10 positions");
            matrixV2.ShowPartly(5, 5, 10, 10);
            ExDeviderV2.DivideByText("with error");
            matrixV2.ShowPartly(10, 10, 5, 10);

            // Delay.
            Console.ReadKey();

        }
    }
}
