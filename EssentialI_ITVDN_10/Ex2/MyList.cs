using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_10
{
    class MyList<T> : IMyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[0];

          
        }


        public T this[int index]
        {
            get 
            {
                if (index < 0 || index > array.Length)
                {
                    Console.WriteLine("Index out of array!\n first element shown: ");
                    return this.array[0];
                }
                else
                    return this.array[index];
            }
        }

        public int Count
        {
            get { return this.array.Length; }
        }

        public void Add(T a)
        {
            T[] tempArray = new T[this.array.Length + 1];

            for (int i = 0; i < this.array.Length; i++)
            {
                tempArray[i] = this.array[i];
            }
           
            tempArray[this.array.Length] = a;
            
            this.array = tempArray;   
        }

        public void Clear()
        {
            this.array = new T[0];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if ((int)(object)this.array[i] == (int)(object)item)
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
