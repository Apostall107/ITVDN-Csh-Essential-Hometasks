using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_01
{
     class Author
    {
        string author;


        public string AuthorFill
        {

            set
            {
                author = value;
            }

            private get
            {
                if (author != null)
                    return author;
                else return "No Author name!";
            }

        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(author);
            Console.ResetColor();
            Console.WriteLine(new string('-', 30));
        }

    }
}
