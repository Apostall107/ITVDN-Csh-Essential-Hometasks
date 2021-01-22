using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_05
{
    class MyMatrixV2
    {
        int[][] matrix;


        public int this[int index1, int index2]
        {
            get 
            {
                if (index1 >= 0 && index1 < matrix.Length      && index2 >= 0 && index2 < matrix[0].Length)
                    return matrix[index1][index2];
                Console.WriteLine("Values of indexes out of matrix sizes.");
                return 0;
            }


            set 
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                    matrix[index1][index2] = value;
                else
                    Console.WriteLine("Values of indexes out of matrix sizes.");
                
            }
        }
            
        
        


        public MyMatrixV2(int n, int m)
        {
            matrix = new int[Math.Abs(n)][];
            for (int i = 0; i < Math.Abs(n); i++)
                matrix[i] = new int[Math.Abs(m)];
            Fill();
        }

        public void Fill()
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = rand.Next(10, 90);
        }

        public void ChangeSize(int col, int row)
        {

            if (col <= 0 || row <= 0)
            {
                Console.WriteLine("Sizes can not be lower than 1!!!");

                return;
            }

            //creation of temp array thiw new sizes
            var new_matrix = new int[row][];

            for (int i = 0; i < row; i++)
                new_matrix[i] = new int[col];


            //refill of new aaray with old array values
            for (int i = 0; i < Math.Min(matrix.Length, row); i++)//Math.Min returns lower of 2 values
            {
                for (int j = 0; j < Math.Min(matrix[i].Length, col); j++)//Math.Min returns lower of 2 values
                    new_matrix[i][j] = matrix[i][j];
            }



            //fill new (empty) array blocks
            Random rand = new Random();

            if (row > matrix.Length)//check if there r new empty rows
            {
                for (int i = matrix.Length; i < row; i++)
                {
                    for (int j = 0; j < Math.Min(matrix[0].Length, col); j++)
                        new_matrix[i][j] = rand.Next(100, 200);
                }
            }

            if (col > matrix[0].Length)//check if there r new empty cols
            {
                for (int i = matrix[0].Length; i < col; i++)
                {
                    for (int j = 0; j < row; j++)
                        new_matrix[j][i] = rand.Next(100, 200);
                }
            }

            matrix = new_matrix;

        }

        public void ShowPartly(int start_row,int start_col, int end_row, int end_col)
        {

            if (start_row < 0 || start_col < 0 || end_row > matrix.Length || end_col > matrix[0].Length)
            {
                Console.WriteLine("Value out of array sizes!");
                return;
            }

            if (start_row > end_row || start_col > end_col)
            {
                Console.WriteLine("startin positions can not be bigger than ending ones!!!");
                return;
            }


            //show part
            for (int i = start_row; i < end_row; i++)
            {
                for (int j = start_col; j < end_col; j++)
                    Console.Write("{0}  ", matrix[i][j]);
               
                Console.WriteLine();
            }
        }

        public void Show()
        {
            ShowPartly(0, 0, matrix.Length, matrix[0].Length);
        }

    }
}
