using System;

namespace EssentialI_ITVDN_05
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] valueUA = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book";     valueUA[0] = "книжка";      
            key[1] = "ручка"; value[1] = "pen";      valueUA[1] = "ручка";
            key[2] = "солнце"; value[2] = "sun";     valueUA[2] = "сонце";
            key[3] = "яблоко"; value[3] = "apple";   valueUA[3] = "яблуко";
            key[4] = "стол"; value[4] = "table";     valueUA[4] = "стыл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + value[i] + " - " + valueUA[i];
                    else if (value[i] == index)
                        return value[i] + " - " + key[i] + " - " + valueUA[i];
                    else if (valueUA[i] == index) 
                        return valueUA[i] + " - " + key[i] + " - " + value[i];


                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index] + " - " + valueUA[index];
    
                else
                    return "Попытка обращения за пределы массива.";
            }
        }      
    }
}
