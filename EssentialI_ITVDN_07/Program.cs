using System;

namespace EssentialI_ITVDN_07
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Changed!";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Changed!";
        }



        static void Main(string[] args)
        {
            ExDeviderV2.AdditionalEx();

            Notebook notebook = new Notebook("Banana", "Mama Africa", 999);
             new Notebook().Show();

            ExDeviderV2.Ex2();

            Train[] bigTrain = new Train[3];

            ClassForTrain trainClass = new ClassForTrain();

            trainClass.AddTrain(bigTrain);
            trainClass.Search(bigTrain);

            ExDeviderV2.Ex3();
           
            string text = "unchanged!!";
            MyClass myClass = new MyClass(text);
            var myStruct = new MyStruct(text);

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            
            ExDeviderV2.Line();
            ClassTaker(myClass);
            StructTaker(myStruct);
        
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            ExDeviderV2.Line();

            Console.ReadKey();
        }
    }
}
