using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_14
{

    public class MyList<T> : IEnumerator<T>, IEnumerable<T>
    {
        T[] array = null;

        public MyList()
        {
            array = new T[0];
        }


        public T this[int index]
        {
            get 
            { 
                return array[index];
            }
        }



        public void Add(T elem)
        {
            T[] arr = new T[array.Length + 1];
            array.CopyTo(arr, 0);
            arr[array.Length] = elem;
            array = arr;
        }


        int current = -1;
     
        
        public int Count
        {
            get { return array.Length; }
        }
      
        public T Current
        {
            get
            {
                return array[current];
            }
        }

        object IEnumerator.Current
        {

            get
            {
                return array[current];
            }

        }




        public void Reset()
        {
            current = -1;
        }


        public bool MoveNext()
        {
            if (current < array.Length - 1)
            {
                current++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }



        IEnumerator IEnumerable.GetEnumerator()
        {

            return this as IEnumerator;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this as IEnumerator<T>;
        }


        public void Dispose()
        {

        }



        
    }
}
