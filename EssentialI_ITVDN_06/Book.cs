using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_06
{
    class Book
    {

       static public class Notes
        {
            static string note = "";

            static public string Text 
            {
                get 
                {
                    return note;
                }

                set
                {
                    if (value != "")
                        note += "\n";
                    note += value;
                }
              
            }
                
                

        }

        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }

    }
}
