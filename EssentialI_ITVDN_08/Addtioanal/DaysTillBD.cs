using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_08
{
    class DaysTillBD
    {

        public DaysTillBD(int year, int mounth, int day)
        {
            Console.WriteLine( "Time untill birthday: " +new DateTime(year, mounth, day).Subtract(DateTime.Now));
        }

    }


}
