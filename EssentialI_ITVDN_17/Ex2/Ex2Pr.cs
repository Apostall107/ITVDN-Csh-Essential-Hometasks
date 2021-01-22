using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EssentialI_ITVDN_17.Ex2
{
    class Ex2Pr
    {

        public static void Show()
        {
            ExDeviderV2.Ex2();

            var listAuto = new List<Auto>
                                           {
                                               new Auto("Fiat", "Bravo", 2005, "red"),
                                               new Auto("Mersedes", "E", 2010, "black"),
                                               new Auto("Skoda", "Fabia", 2009, "yellow"),
                                               new Auto("Mersedes","A", 2009, "grey")
                                           };

            foreach (var auto in listAuto)
            {
                Console.WriteLine(auto.ToString());
            }

            ExDeviderV2.Line();

            var listCustomer = new List<Customer>
                                               {
                                                   new Customer( "Petrov","Mersedes", "0509864578"),
                                                   new Customer( "Ivanov", "Fiat", "0509876545"),
                                                   new Customer( "Vasiliev", "Skoda", "0504789863")
                                               };

            foreach (var customer in listCustomer)
            {
                Console.WriteLine(customer.ToString());
            }

            ExDeviderV2.DoubleLine();


            var query =
                from customer in listCustomer
                join auto in listAuto
                on customer.Model equals auto.Mark
                select new
                {
                    Name = customer.Name,
                    Model = customer.Model,
                    Tel = customer.Tel,
                    Mark = auto.Model,
                    Year = auto.Year,
                    Color = auto.Colour
                };

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Name} {item.Tel} {item.Model} {item.Mark} {item.Color} {item.Year}");
            }








        }

    }
}
