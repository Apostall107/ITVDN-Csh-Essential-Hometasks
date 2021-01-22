using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_15
{
    struct Worker
    {
        string name,
                  post;
        int year;
        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Post
        {
            get
            {
                return post;
            }
        }

        public int Year
        {
            set
            {
                if (value <= DateTime.Now.Year && DateTime.Now.Year - value < 80)
                    year = value;
                else
                {
                    Console.WriteLine("Try again!");
                    Year = Convert.ToInt32(Console.ReadLine());
                }
            }
            get
            {
                return year;
            }
        }
        
        public int Experience()
        {
            return DateTime.Now.Year - year;
        }


        public Worker(string name, string post, int year)
        {
            this.name = name;
            this.post = post;
            this.year = DateTime.Now.Year;
            this.Year = year;
        }

    }
}
