using System;

namespace EssentialI_ITVDN_06
{

    class Program
    {

        static void Main(string[] args)
        {
             ExDeviderV2.AdditionalEx();

            Book.Notes.Text = "123456789";
            Book.Notes.Text = "1st note";
            Book.Notes.Text = "2nd note";
            Book.Notes.Text = "3rd note";
            Book.Notes.Text = "4th note";

            FindAndReplaceManager.FindNext("2nd note"+" найдена");

            ExDeviderV2.DoubleLine();

            int[] array = new int[100];

            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(0, 100);

            foreach (int el in array)
                Console.Write("{0} ", el);

           

           ExDeviderV2.DivideByText("Sorted Array:");

                array.SortArray(0,array.Length-1);

            foreach (int el in array)
                Console.Write("{0} ", el);


        }
    }



}

