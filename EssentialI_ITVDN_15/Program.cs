using System;

namespace EssentialI_ITVDN_15
{
    class Program
    {
        static void Main(string[] args)
        {
           ExDeviderV2.AdditionalEx(); //--------------------------------------------------------------------------------------------------------------------
       
            AdditionalEx.Show();

            ExDeviderV2.Ex2(); //--------------------------------------------------------------------------------------------------------------------

            Company comp = new Company();
           Console.WriteLine($" Exp is more than 5 years have:\n { comp[5]}");

            ExDeviderV2.Ex3();//--------------------------------------------------------------------------------------------------------------------

            Product_list priceTable = new Product_list();


            Console.WriteLine("\nSorted list by shops name! '");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(priceTable[i]);
            }

            ExDeviderV2.Line();
            
            Console.WriteLine("enter product id/name to seach:");
            string product = Console.ReadLine();

            Console.WriteLine(priceTable[product]);

        }
    }
}
