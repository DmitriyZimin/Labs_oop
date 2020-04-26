using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    abstract class Cars
    {
        public string name;
        public int horsepower;
        public double price;
                                   
        public void GetInfo()
        {
            Console.WriteLine("name {0}, horsepower {1}, price {2}", name, horsepower, price);
        }

        public abstract void Move();
    }
}

