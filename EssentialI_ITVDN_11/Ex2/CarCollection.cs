using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_11
{
    class CarCollection<T> : MyList<T>
    {
        public readonly MyList<string> car_name;
        public readonly MyList<DateTime> car_year;
        
        public new string this[int index]
        {
            get
            {
                if (index < car_name.Count)
                    return car_name[index] + " " + car_year[index].Year + " year";
                return "No cars with that index found!";
            }
        }
       public CarCollection()
        {
            this.car_name = new MyList<string>();
            this.car_year = new MyList<DateTime>();
        }

        public void AddCar(string name,DateTime date)
        {
            car_name.Add(name);
            car_year.Add(date);
        }

        public string CarCount()
        {
            return $"Count of cars: {car_name.Count}";
        }


        public void ClearCars()
        {
            car_name.Clear();
            car_year.Clear();
        }


    }
}
