using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_07
{
    struct Notebook
    {
        string model, producer;
        int price;

        public Notebook(string model, string producer, int price)
        {
            this.model = model;
            this.price = price;
            this.producer = producer;
            Show();
        }

       public void Show()
        {
            Console.WriteLine(
                "model: {0}.\n" +
                "produced by: {1}.\n" +
                "price: {2}."
                ,model,producer,price);
            ExDeviderV2.Line();
        }

    }
}
