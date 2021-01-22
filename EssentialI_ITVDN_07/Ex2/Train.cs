using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_07
{
   public struct Train
    {
        

        string destination;
        int number;
        DateTime departure_time;

        public int Number 
        { 
            get 
            { 
                return number; 
            } 
        }

        public Train(string destination, int number, DateTime departure_time)
        {
            this.departure_time = departure_time;
            this.destination = destination;
            this.number = number;

        }

        public void Show()
        {

            Console.WriteLine($"Departure time:{departure_time}\n train number:{number}\n its destination is: {destination}"

                , departure_time, destination, number);
            ExDeviderV2.Line();
        }

    }
}
