using System;
using System.Collections;
using System.Linq;

namespace EssentialI_ITVDN_04
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string myFile = "myFile";

            new XMLHandler(myFile).ShowInfoXML();
            new DOCHandler(myFile).ShowInfoDOC();
            new TXTHandler(myFile).ShowInfoTXT();

            new ExDevider("Ex3");

            Player myPlayer = new Player();

            IRecordable myRecorder = myPlayer as IRecordable;
            IPlayeble myPlayeble = myPlayer as IPlayeble;

            IEnumerable instance = new ArrayList();

            Console.ReadKey();

            instance = instance as IQueryable;

            myPlayeble.Play();
            myRecorder.Record();
            myPlayeble.Stop();
            myRecorder.Stop();

            Console.ReadKey();
        }
    }
}
