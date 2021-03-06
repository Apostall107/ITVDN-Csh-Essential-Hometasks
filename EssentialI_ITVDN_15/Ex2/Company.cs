﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssentialI_ITVDN_15
{
    class Company
    {
        Worker[] staff;
        public string this[int index]
        {
            get
            {
                int i = 0;
                string tmp = "";
                while (i < staff.Length - 1)
                {
                    i++;
                    if (index <= staff[i].Experience())
                    {

                        tmp += staff[i].Name + "\n";

                    }
                }

                return tmp;
            }
        }

        public Company()
        {
            string name;
            string post;
            int year;
            string tmp;

            staff = new Worker[5];




            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите имя сотрудника");
                name = Console.ReadLine();

                Console.WriteLine("Введите должность");
                post = Console.ReadLine();

                Console.WriteLine("Введите год начала работы ");
                tmp = Console.ReadLine();

                try
                {
                    year = Convert.ToInt32(tmp);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unullowed year value entered! ");
                    Console.WriteLine(e.Message);
                    year = DateTime.Now.Year;


                }
               
                staff[i] = new Worker(name, post, year);
                
                ExDeviderV2.Line();
            }
        
            
            Sort();

        }


        void Sort()
        {
            staff.OrderBy(staff => staff.Name);
        }
    }
}
