using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_17.Ex2
{
    class Customer
    {

        readonly string name;
        readonly string model;
        string number;

        public Customer(string name, string model, string tel)
        {
            this.name = name;
            this.model = model;
            this.number = tel;
        }

        public string Model
        {
            get { return model; }
        }

        public string Name
        {
            get { return name; }
        }
        public string Tel
        {
            get { return number; }
        }




        public override string ToString()
        {
            return "Consumer: " + name + " Model: " + model + " Phone num: " + number + "\n";
        }



    }

 
}



// 0:(###) ###-####
//String.Format("{0:(###) ###-#### x ###}", double.Parse("1234567890123"))
