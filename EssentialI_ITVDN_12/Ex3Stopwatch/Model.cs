using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3Stopwatch
{
    class Model
    {
      
        public int sec = 0,
            min = 0,
            hrs = 0;

       public string TimerTime()
        {
            sec++;
            if (sec >= 60)
            {
                sec = 0;
                min++;
            }
            if (min >= 60)
            {
                min = 0;
                hrs++;
            }

            return $"{hrs}:{min}:{sec}";
        }




    }
}
