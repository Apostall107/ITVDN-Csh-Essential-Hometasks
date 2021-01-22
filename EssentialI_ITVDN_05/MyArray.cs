using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_05
{
    class MyArray
    {
        int[] myArray;

        public MyArray(int[] array, int N)
        {
            myArray = new int[N];

            for (int i = 0; i < N; i++)
            {
                myArray[i] = array[i];
            }
        }

        private int MaxEl()
        {
            int max = this.myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (max < myArray[i])
                {
                    max = myArray[i];
                }
            }
            return max;
        }

        private int MinEl()
        {
            int min = this.myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (min > myArray[i])
                {
                    min = myArray[i];
                }
            }
            return min;
        }

        private int ElSum()
        {
            int sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                    sum += myArray[i];  
            }
            return sum;
        }

        private int ElAvg()
        {
            return ElSum() / myArray.Length;
        }


        private void ShowNotDivByTwo()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i % 2 != 0) 
                    Console.WriteLine("index:{0} - is: {1} ",i,myArray[i]);
            }
        }


        public void ShowArrayEx()
        {
            Console.WriteLine
                (
                $"\nMax element of array = {MaxEl()}\n" +
                $"Min element of array = {MinEl()}\n" +
                $"Sum of elements = {ElSum()}\n" +
                $"Avg of all elements = {ElAvg()}\n" +
                $"\n\n"
                , MaxEl(), MinEl(), ElSum(), ElAvg()
                );
            ShowNotDivByTwo();
        }

    }
}
