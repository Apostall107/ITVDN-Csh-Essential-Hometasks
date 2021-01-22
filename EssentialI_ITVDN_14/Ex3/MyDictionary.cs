using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EssentialI_ITVDN_14
{
    class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        private  TKey[] key;
        private  TValue[] value;
        private  int lenght = 0;

        int position = -1;

        public MyDictionary()
        {
            value = new TValue[0];
            key = new TKey[0];
        }

        public int Lenght
        {
            get { return lenght; }
        }

        public void Add(TKey k, TValue l)
        {
            TKey[] new_key = new TKey[key.Length + 1];
            key.CopyTo(new_key, 0);
            new_key[key.Length] = k;
            this.key = new_key;

            TValue[] new_value = new TValue[value.Length + 1];
            value.CopyTo(new_value, 0);
            new_value[value.Length] = l;
            this.value = new_value;

            lenght++;
        }

        #region Indexer
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                return "out of dictionary index!";
            }
        }

        #endregion

        #region Realisation of IEnumrator
        public object Current
        {
            get 
            {
              return key[position] + " " + value[position];
            }
        }

        public void Dispose()
        {
            
        }
        #endregion

        #region Realisation IEnumerable<T>

        public IEnumerator<object> GetEnumerator()
        {
            return this as IEnumerator<object>;
        }

        public bool MoveNext()
        {
            if (position < key.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }

        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
        #endregion

    }
}
