using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_16.Ex3
{
    class House : ICloneable
    {
        private string room = "my room";
        private string toilet = "my toilet";

        public House()
        { }

        public House(string room, string toilet)
        { 
           this.room = room;
            this.toilet = toilet;
        }

        public string Toilet
        {
            get
            {
                return toilet;
            }
            set
            {
                toilet = value;
            }
        }
        public string Room
        {
            get
            {
                return room;
            }
            set
            {
                room = value;
            }
        }

        public void UseMyToilet()
        {
            Console.WriteLine("use " + room);
        }

        public void UseMyRoom()
        {
            Console.WriteLine("use " + toilet);
        }

        public object Clone()
        {
            return new House(this.room, this.toilet) as object ;
        }

        public override string ToString()
        {
            return "room: " + room + " \ntoilet: " + toilet;
        }

    }
}
