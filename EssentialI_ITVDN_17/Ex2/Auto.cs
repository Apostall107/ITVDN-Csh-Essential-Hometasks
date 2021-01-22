using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_17.Ex2
{
    class Auto
    {
        readonly string mark;
        readonly string model;
        readonly int year;
        private readonly string colour;

        public Auto(string mark, string model, int year, string colour)
        {
            this.mark = mark;
            this.model = model;
            this.year = year;
            this.colour = colour;
        }

        public string Colour
        {
            get { return colour; }
        }

        public string Model
        {
            get { return model; }
        }

        public int Year
        {
            get { return year; }
        }

        public string Mark
        {
            get { return mark; }
        }

        public override string ToString()
        {
            return "Mark: " + mark + " Model: " + model + " Year: " + year + " Colour: " + colour + "\n";
        }
    }
}
