using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_03
{
    class Vehicle
    {
        readonly int X, Y;//coordinates

        readonly uint speed,price,year;

        public Vehicle(int X, int Y,uint speed, uint price, uint year)
        {
            this.X = X;
            this.Y = Y;
            this.speed = speed;
            this.price = price;
            this.year = year;
        
        }

         int GetX() 
        {
            return X;
        }
         int GetY()
        {
            return Y;
        }
         uint GetSpeed()
        {
            return speed;
        }
         uint GetPrice()
        {
            return price;
        }
         uint GetYear()
        {
            return year;
        }

        protected void ShowInfo()
        {
            Console.Write
                (
                $"\n\nCurrent coordinates X:{X} Y:{Y}.\n" +
                $"Vehisle price: {price}. \n" +
                $"Vehisle speed: {speed}km/h. \n" +
                $"Vehisle year of production: {year}. \n"
                ,year,Y,price,speed,Y
                );
        }
        

    }
     
    class  Plane :Vehicle
    {
        readonly uint hight, passangers;

        public Plane(int X, int Y, uint speed, uint price, uint year, uint hight, uint passangers) : base(X, Y, speed, price, year)
        {
            this.hight = hight;
            this.passangers = passangers;
        }

        public void ShowInfo()
        {
            base.ShowInfo();

            Console.Write
        (
        $"Passangers: {passangers}.\n" +
        $"Hight of flight - {hight}m\n"
        , passangers, hight
        );
            Console.WriteLine();
        }

    }

    class Car : Vehicle
    {
        public Car(int X, int Y, uint speed, uint price, uint year) : base(X, Y, speed, price, year)
        {

        }

        public void ShowInfo()
        { 
          base.ShowInfo();
            Console.WriteLine();
        } 

    }

    class Ship :Vehicle
    {
        readonly uint passangers;
        readonly string port;
        public Ship(int X, int Y, uint speed, uint price, uint year, uint passangers, string port) : base(X, Y, speed, price, year)
        {
            this.passangers = passangers;
            this.port = port;
        }

        public void ShowInfo() 
        {
            base.ShowInfo();

            Console.Write
        (
        $"Passangers: {passangers}.\n" +
        $"Home port location - {port}\n" 
        ,passangers,port
        );
            Console.WriteLine();
        }

    }

}
