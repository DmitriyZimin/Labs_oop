using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger_cars x = new Passenger_cars();

            x.name = "Toyota";
            x.horsepower = 106;
            x.price = 1549000.20;

            x.GetInfo();
            x.Move();
            x.TrasportingPassengers();

            Buses y = new Buses();

            y.name = "Man";
            y.horsepower = 120;
            y.price = 1870000.80;

            y.GetInfo();
            y.Move();
            y.TrasportingPassengers();

            Trucks z = new Trucks();

            z.name = "Kamaz";
            z.horsepower = 150;
            z.price = 2000000.30;

            z.GetInfo();
            z.Move();
            z.CargoDelivery();
        }
    }
}
