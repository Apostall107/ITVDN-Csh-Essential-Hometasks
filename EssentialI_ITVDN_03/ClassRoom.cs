using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_03
{
    

    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];
        public ClassRoom(Pupil p0, Pupil p1, Pupil p2, Pupil p3)
        {
            pupils[0] = p0;
            pupils[1] = p1;
            pupils[2] = p2;
            pupils[3] = p3;

        }

        public ClassRoom(Pupil p0, Pupil p1, Pupil p2)
        {
            pupils[0] = p0;
            pupils[1] = p1;
            pupils[2] = p2;
            pupils[3] = GeneratePupil();
        }

        public ClassRoom(Pupil p0, Pupil p1)
        {
            pupils[0] = p0;
            pupils[1] = p1;
            pupils[2] = GeneratePupil();
            pupils[3] = GeneratePupil();
        }

        public void ShowPupilSkills()
        {
            int counter = 1;
            foreach (Pupil p in pupils)
            {
                Console.WriteLine("\nPupil #{0} ", counter);

                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                
                counter++;

            }
            Console.WriteLine("END OF CLASSROOM");

        }


        Random rand = new Random();

        Pupil GeneratePupil()
        {
           
            int r = rand.Next(1, 4);

            switch (r)
            {
                case 1: return new ExcelentPupil();
                case 2: return new GoodPupil();
                case 3: return new BadPupil();
            }
            return new BadPupil();
        }



    }


}
