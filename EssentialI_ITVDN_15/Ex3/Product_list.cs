using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace EssentialI_ITVDN_15
{
    class Product_list
    {
        struct StrucPrice
    {
        string
            id,
            shop_name;
        decimal price;


        public string Id
        {
            get
            {
                return id;
            }
        }


        public string Shop_Name
        {
            get
            {
                return shop_name;
            }
        }

        public decimal Price
        {
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    Price = Convert.ToDecimal(Console.ReadLine());
                }

            }

            get
            {
                return price;
            }

        }


        public StrucPrice(string name, string shop_name, decimal price)
        {
            this.price = price;
            this.id = name;
            this.shop_name = shop_name;
        }


        public string Show()
        {
            return $"Product {id} from  {shop_name} costs: {price} UAH\n";
        }



    }




   
        StrucPrice[] product;
        public string this[string index]
        {
            get
            {
                string tmp = "";
                for (int i = 0; i < product.Length ; i++)
                {
                    if (index == product[i].Id) 
                        tmp += product[i].Show();
                }
                if (string.IsNullOrEmpty(tmp) == true)
                {
                    return "no matches found!\n";
                }
                 else
                    return tmp;
                
            }
        }
        
        public string this[int index]
        {
            get
            {
                return product[index].Show();
            }
        }




        public Product_list()
        {
            string
                id,
                shop_name;
            decimal price;
            product = new StrucPrice[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter its id/name");
                id = Console.ReadLine();

                Console.WriteLine("Enter shop name");
                shop_name = Console.ReadLine();

                Console.WriteLine("enter price");
                try
                {
                    price = Convert.ToUInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unrestricted value entered.");
                    Console.WriteLine(e.Message);
                    price = 0;
                }
                product[i] = new StrucPrice(id, shop_name, price);
            }
         //  product = product.OrderBy(products => products.Id).ToArray<StrucPrice>();
            product.OrderBy(products => products.Id);
        }


    }



}