using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_05
{
    class Store
    {
        Article[] articles;

          public Article this[int index]
        {
            get
            {
                return articles[index];
            }
            set
            {
                articles[index] = value;
            }
        }
        
        
        
        public Store(int index)
        {
             articles = new Article[index];
        }

        public string SearchByIndex(int index)
        {

            if (articles.Length > index) 
                    return articles[index].Info();

            return string.Format("\"{0}\" no such product(out of range index).", index);
        }


        public string SearchByProductName(string searching_product)
        {
            for (int i = 0; i < articles.Length; i++)
                if (articles[i].product_name == searching_product)
                    return articles[i].Info();

            return string.Format("\"{0}\" no such product.", searching_product);
        }

        public void AddArticle(Article value, int index)
        {

            if (index >= 0 && index < articles.Length)
                articles[index] = value;
            else
                Console.WriteLine("Index out if range!");

        }



    }
}
