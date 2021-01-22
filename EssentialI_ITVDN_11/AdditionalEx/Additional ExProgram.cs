using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace EssentialI_ITVDN_11
{
    static class Additional_ExProgram
    {
        static public void Show()
        {
            ExDeviderV2.AdditionalEx();

            ArrayList myAL = new ArrayList();
           
            myAL.Add("string");
            myAL.Add(12);

            Console.WriteLine("foreach  in ArrayList: ");
            foreach (var el in myAL)
                Console.WriteLine(el);

            ExDeviderV2.Line();

            Console.WriteLine(" for  in ArrayList: ");
            for (int i = 0; i < myAL.Count; i++)
                Console.WriteLine(myAL[i]);


            ExDeviderV2.Line();
        }






    }
}
