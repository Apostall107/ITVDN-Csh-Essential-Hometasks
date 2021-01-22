using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_16.Ex4
{
    class MyDate
    {

        DateTime date;

        public MyDate(DateTime date)
        {
            this.date = date;
        }

       

        public static int operator  -(MyDate first_date, MyDate second_date )
        {

                TimeSpan span = first_date.date - second_date.date;
                return (int)span.TotalDays;
             
        }

        public static  DateTime operator +(MyDate date ,double days)
        {

            return date.date.AddDays(days);
        }




        public override string ToString()
        {
            return "Date: " + date;
        }


    }
}
