using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Passenger_cars : Cars, Interface_1
    {
        public Passenger_cars(string name, int horsepower, double price)
        {
            this.name = name;
            this.horsepower = horsepower;
            this.price = price;
        }
        public override void Move ()
        {
            Console.WriteLine("Move fast");
        }

        public void TrasportingPassengers()
        {
            Console.WriteLine("Passenger cars. Can be used for transporting people");
        }

    }
}
