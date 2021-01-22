using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_11
{
    class MyDictionary<Tkey, TValue>
    {
        Tkey[] key;
        TValue[] value;
        int lenght ;


        public MyDictionary()
        {
            this.key = new Tkey[0];
            this.value = new TValue[0];
            this.lenght = 0;
        }


        public string this[int index]
        {
            get
            {
                if (index < 0 || index > this.lenght)
                {
                    return "index out of array!";
                }
                return "En: " + key[index] + " - Ru: " + value[index];
            }

        }


        public void Add(Tkey k, TValue v)
        {

            var tempKey = new Tkey[this.key.Length + 1];
            var tempValue = new TValue[this.value.Length + 1];


            for (int i = 0; i < this.key.Length; i++)
            {

                tempKey[i] = this.key[i];
                tempValue[i] = this.value[i];

            }

            tempKey[this.key.Length] = k;
            tempValue[this.key.Length] = v;

            this.key = tempKey;
            this.value = tempValue;
            this.lenght++;

        }
        public void ShowDict()
        {
            Console.WriteLine($"Dictionary contains {lenght} words. \n");
            for (int i = 0; i < lenght; i++)
                Console.WriteLine($" En: {key[i]} - Ru: {value[i]}");

        }

     
        public string Contains(string item)
        {
            for (int i = 0; i < this.lenght; i++)
            {
                if ((string)(object)this.key[i] == item || (string)(object)this.value[i]== (string)(object)item)
                {
                    return "match found!\n En: " + key[i] + " - Ru: " + value[i];
                }
            }

            return "no matches found!";
        }


    }
}
