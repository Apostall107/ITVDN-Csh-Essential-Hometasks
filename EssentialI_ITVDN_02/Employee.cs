using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_02
{
   
    
    class Employee
    {
         
        
        string name, surname;
        string[] Positions = //0-3
        {
            "Homeless",
            "Worker",
            "Manager",
            "Director"
        };//0-3

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }


        double koef = 1.0;



        public int ShowCountSal(int salary,int exp,string position,double tax)
        {
            int posCheck=-1;

            for (int i = 0; i <Positions.Length; i++)
            {
                if (position == Positions[i])
                {
                    posCheck = i;
                }


            }

            switch (posCheck)
            {
                case 1:
                    koef *= 1.1;
                    break;
                case 2:
                    koef *= 1.3;
                    break;
                case 3:
                    koef *= 1.8;
                    break;
                case 0:
                    koef = 0;
                    break;
                default:
                    Console.WriteLine($"{name} {surname}. \nUr not working for us!!!\n\n", name, surname);
                    return 0;
            }

            switch (exp)
                {
                    case 0:
                        koef *= 1.0;
                        break;
                    case 1:
                        koef *= 1.1;
                        break;
                    case 2:
                        koef *= 1.3;
                        break;
                    default:
                        koef *= 1.5;
                        break;
                }

                double sal_koef = salary * koef;
                double taxValue = sal_koef * tax / 100;
                double res_sal = sal_koef - taxValue;

                Console.WriteLine($"{name} {surname}. " +
                    $"\nUr position is {position}" +
                    $"\nUr salary = {sal_koef}, " +
                    $"\nUr tax value = {taxValue} , its {tax}% tax" +
                    $"\nUr resulting salary = {res_sal} \n\n"
                    ,name, surname, position,sal_koef,taxValue,tax,res_sal);
                return 0; 


            }

        }

}














