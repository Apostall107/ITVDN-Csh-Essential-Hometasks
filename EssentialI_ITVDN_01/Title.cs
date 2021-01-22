using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_01
{
    class Title
    {
        string title;


        public string TitleFill
        {

            set 
            {
                title = value;
            }

            private get
            {
                if (title != null)
                    return title;
                else return "No Title name!";
            }

        }

        public void Show()
        {
            Console.WriteLine(new string('-', 30));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
        }
    
    
    }
}
