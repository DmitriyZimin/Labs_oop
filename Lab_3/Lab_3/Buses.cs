using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Buses : Cars, Interface_1
    {
        public override void Move()
        {
            Console.WriteLine("Moves slowly");
        }

        public void TrasportingPassengers()
        {
            Console.WriteLine("Bus. Can be used for transporting people");
        }
    }
}
