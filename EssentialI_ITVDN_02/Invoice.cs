using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_02
{
    class Invoice
    {
        readonly int  account;
        readonly string customer,provider;

        string article;
        int quantity;

        int price;
        public Invoice(int account,string customer,string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;

        }

        double PriceVAT(double VAT)//Value-added tax (VAT)
        {
            
            return (price * quantity)*(1+(VAT/100));
        }
        double Price_no_VAT()
        {
            switch (article)
            {
                case ("SSD"):
                    price = 100;
                    break;
                case ("Super SSD"):
                    price = 200;
                    break;
                case ("Definetely not one more SSD"): price = 999;
                    break;
                default: this.article = "empty"; price = 0; break;
            }

            return price*quantity;
        }

        public void ShowPrices(string article,int quantity,double VAT)
        {
            this.article = article;
            this.quantity = quantity;
            Console.WriteLine
                (
                $"dear {customer}! \n" +
                $"id: {account}. \n" +
                $"You ordered {article} x {quantity}. \n" +
                $"Product will be provided by {provider} \n" +
                $"in price of  {Price_no_VAT()}\n" +
                $"final price with VAT({VAT}%) is: {PriceVAT(VAT)}\n\n"
                ,account,customer,provider,article,quantity,VAT, Price_no_VAT(), PriceVAT(VAT)
                );
        }


    }
}
