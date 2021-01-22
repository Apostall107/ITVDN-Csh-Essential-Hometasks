using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_07
{
    class ClassForTrain : IforTrain
    {
        public void AddTrain(Train[] bigTrain)
        {
            for (int i = 0; i < bigTrain.Length; i++)
            {
                Console.Write("Enter the point of destination:");
                string destination = Console.ReadLine();
                destination = string.IsNullOrEmpty(destination) ? "Point of destination was not entered!" : destination;

                Console.Write("Enter train number:");
                string n = Console.ReadLine();
                int number = string.IsNullOrEmpty(n) ? 0 : Convert.ToInt32(n);

                Console.Write("Enter departure date:");
                n = Console.ReadLine();
                DateTime date = string.IsNullOrEmpty(n) ? DateTime.Now : DateTime.Parse(n);

                bigTrain[i] = new Train(destination, number, date);
            }

            Sort(bigTrain);

            Show(bigTrain);

        }

        public void Search(Train[] bigTrain)
        {
            Console.Write("Enter train number you are looking for:");
            string n = Console.ReadLine();
            int number = string.IsNullOrEmpty(n) ? 0 : Convert.ToInt32(n);

            bool flag = false;
            for (int i = 0; i < bigTrain.Length; i++)
            {
                if (bigTrain[i].Number == number)
                {
                    bigTrain[i].Show();
                    flag = true;
                }
                    if (flag == false)
                    Console.WriteLine("No matches found!!!");

            }

        }

        public void Sort(Train[] bigTrain )
        {
                for (int i = 0; i < bigTrain.Length; i++)
                {
                    for (int j = 0; j < bigTrain.Length; j++)
                    {
                        if (bigTrain[i].Number <= bigTrain[j].Number)
                        {
                            Train tempTrain = bigTrain[i];
                            bigTrain[i] = bigTrain[j];
                            bigTrain[j] = tempTrain;
                        }
                    }
                }
            

        }
        public void Show(Train[] bigTrain)
        {
            for (int i = 0; i < bigTrain.Length; i++)
            {
                Console.WriteLine($"{i}:\n", i);
                    bigTrain[i].Show();
            }

        }

    }
}
