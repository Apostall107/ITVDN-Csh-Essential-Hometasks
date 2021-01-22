using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_01
{
    class Content
    {
        string content;

        public string ContentFill
        {

            set
            {
                content = value;
            }

            private get
            {
                if (content != null)
                    return content;
                else return "No content !";
            }

        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(content);
        }


    }
}
