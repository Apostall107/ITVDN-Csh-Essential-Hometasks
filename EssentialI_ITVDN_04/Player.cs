using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_04
{
    class Player : IRecordable , IPlayeble
    {
        void IPlayeble.Play() 
        { 
            Console.WriteLine("Play!!!");
        }
        void IPlayeble.Pause() 
        {
            Console.WriteLine("Pause!");
        }
        void IPlayeble.Stop() 
        {
            Console.WriteLine("Stop!");
        }

        void IRecordable.Record() 
        {
            Console.WriteLine("Start record!");
        }
        void IRecordable.Pause() 
        {
            Console.WriteLine("Pause record!");
        }
        void IRecordable.Stop() 
        {
            Console.WriteLine("Stop record!");
        }

    }


}
