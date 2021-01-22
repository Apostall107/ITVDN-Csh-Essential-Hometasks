using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_05
{
    class MyMatrix
    {
         int[,] myMatrix;

         int rows { get; set; } 
         int col { get; set; }

        public MyMatrix(int rows, int col)
        {
            this.rows = rows;
            this.col = col;
            myMatrix = new int[rows,col];
            Fill();
        }

         MyMatrix(MyMatrix matrix,int raws,int col)
        {
           MyMatrix newMatrix = new MyMatrix(raws, col);
          
            newMatrix.ReFill(matrix);
            

        }

         void ReFill(MyMatrix baseMatrix)
        {
            int hight,length;
            if (baseMatrix.rows < this.rows)
                hight = baseMatrix.rows;
            else
                hight = this.rows;


            if (baseMatrix.col < this.col)
                length = baseMatrix.col;
            else
                length = this.col;



            for (int i = 0; i < hight; i++)
                for (int j = 0; j < length; j++)
                    this.myMatrix[i, j]= baseMatrix.myMatrix[i,j];

            baseMatrix.myMatrix = this.myMatrix;
            baseMatrix.rows = this.rows;
            baseMatrix.col = this.col;
        }

         void Fill()
        {
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < col; j++)
                    myMatrix[i,j] = rand.Next(10, 90);
        }

        void ShowMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                    Console.Write("{0} ",myMatrix[i, j]);
            }
            Console.Write("\n {0}", (new string('-', 30)));
        }

        public void ChangeSizeRaws(MyMatrix matrix,int size)
        { 
           matrix =  new MyMatrix(matrix, this.rows + size,col);

           ShowMatrix();
            

        }

        public void ChangeSizeColumns(MyMatrix matrix, int size)
        {
            matrix = new MyMatrix(matrix, this.rows, this.col + size);

            ShowMatrix();

        }

        public void ShowPart(int rows, int columns)
        {
            if (rows > this.rows || columns > this.col)
                Console.WriteLine("\nSize out of Matrix range!\n");
            else
            {
                Console.WriteLine("\nMatrix part {0} x {1}:\n\n", rows, columns);
                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < columns; j++)
                        Console.Write("{0} ", myMatrix[i, j]);
                }

                Console.WriteLine();
            }

        }

        
        public int this[int index1, int index2]
        { 
            get
            {
                    return myMatrix[index1,index2];
            }

            set
            {
                myMatrix[index1, index2] = value;
            }
        }

    }
}
