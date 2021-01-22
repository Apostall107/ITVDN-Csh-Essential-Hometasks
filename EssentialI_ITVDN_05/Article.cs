using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_05
{
    class Article
    {
       public string product_name { get; set; }
        public string store_name { get; set; }
        int price;
   /*     {
            get 
            { 
                return price;
            }
            set
            {
                if (price < 0)
                {
                    Console.WriteLine("\nPrice can not be below 0!");
                    price = 0;
                }
                else price = value;

            }
        }
   */
        public Article(string name, string shop, int price)
        {
            this.product_name = name;
            this.store_name = shop;
            this.price = price;
        }

        public string Info()
        {
            return string.Format("{0} of {1} price : {2} UAH. ",product_name,store_name,price );
        }

    }
}
