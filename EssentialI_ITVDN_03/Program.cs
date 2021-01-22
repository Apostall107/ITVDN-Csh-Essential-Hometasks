using System;

namespace EssentialI_ITVDN_03
{
    class Program
    {
        static void Main(string[] args)
        {
            new Printer().Print("Первый");
            new PrinterRed().Print("Второй");
            new PrinterBlue().Print("Третий");




            //////////////////////////////////--------------EX2----------///////////////////////////////////
            new ExDevider("EX2");

            Pupil pupil = new Pupil();
            BadPupil badPupil = new BadPupil();
            GoodPupil goodPupil = new GoodPupil();
            ExcelentPupil excelentPupil = new ExcelentPupil();

            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();

            Console.WriteLine(new string('-', 100));

            badPupil.Study();
            badPupil.Read();
            badPupil.Write();
            badPupil.Relax();
            Console.WriteLine("UpCast:");
            Pupil badPupilUp = badPupil as Pupil;//upcast not workin cuz of virtual-override
            badPupilUp.Study();
            badPupilUp.Read();
            badPupilUp.Write();
            badPupilUp.Relax();

            Console.WriteLine(new string('-', 100));

            goodPupil.Study();
            goodPupil.Read();
            goodPupil.Write();
            goodPupil.Relax();
            Console.WriteLine("UpCast:");
            Pupil goodPupilUp = goodPupil as Pupil;
            goodPupilUp.Study();
            goodPupilUp.Read();
            goodPupilUp.Write();
            goodPupilUp.Relax();

            Console.WriteLine(new string('-', 100));

            excelentPupil.Study();
            excelentPupil.Read();
            excelentPupil.Write();
            excelentPupil.Relax();
            Console.WriteLine("UpCast:");
            Pupil excelentPupilUp = excelentPupil as Pupil;
            excelentPupilUp.Study();
            excelentPupilUp.Read();
            excelentPupilUp.Write();
            excelentPupilUp.Relax();




            new ExDevider("ClassRoom");


            new ClassRoom(badPupil, goodPupil, excelentPupil, pupil).ShowPupilSkills();
            new ClassRoom(badPupil, goodPupil).ShowPupilSkills();


            //////////////////////////////////////////////------------------------EX3--------------///////////////////////////////
            new ExDevider("EX3");
            new ExDevider("Vehicle"); 


            new Car(2, -5, 120, 1900, 1999).ShowInfo();

            new Ship(20, 11, 80, 190000,2005,3000, "Alabama").ShowInfo();

            new Plane(20, 11, 80, 190000, 2005, 3000, 10000).ShowInfo();


            //////////////////////////////////////////////------------------------EX4--------------///////////////////////////////
            new ExDevider("EX4");

           
            string flag="";

            switch (flag)
            {
                case "pro":  new ProDocumentWorker().CheckOptions();break;
                case "exp": new ExpertDocumentWorker().CheckOptions();break;
                default: new DocumentWorker().CheckOptions();break;
            }



            Console.ReadKey();
        }
    }
}
