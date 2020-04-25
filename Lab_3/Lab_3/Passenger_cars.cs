using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Passenger_cars : Cars, Interface_1
    {
        public override void Move ()
        {
            Console.WriteLine("Moves fast");
        }

        public void TrasportingPassengers()
        {
            Console.WriteLine("Passenger car. Can be used for transporting people");
        }

    }
}
