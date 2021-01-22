using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_08
{   
    enum Post
    {
        // Post and quantity of hours worked in mounth
        Manager = 195,
        Developer = 200,
        Accountant = 192,
        Secretary = 192,
        Cleaner = 192
    }
   static class Accauntant
    {

        public static bool AskForBonus(Post post,int hours)
        {


            return (hours > (int)post);
        }
    }
}
