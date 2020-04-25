using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Trucks : Cars, Interface2
    {
        public void CargoDelivery()
        {
            Console.WriteLine("Truck. Can be used for goods delivering");
        }

        public override void Move()
        {
            Console.WriteLine("Moves slowly");
        }
    }
}
