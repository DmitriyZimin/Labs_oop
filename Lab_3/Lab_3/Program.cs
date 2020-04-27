using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3
{
    class Program
    {
        [My(author = "Zimin D.")]
        static void Main(string[] args)
        {
            List<Passenger_cars> d = new List<Passenger_cars>();
           
            Passenger_cars x1 = new Passenger_cars("Toyota", 106, 1549000.20);
            Passenger_cars x2 = new Passenger_cars("Lada", 87, 549000.20);
            Passenger_cars x3 = new Passenger_cars("Skoda", 122, 1249000.20);

            x1.GetInfo();
            //x2.GetInfo();
            //x3.GetInfo();
            x1.Move();
            x1.TrasportingPassengers();

            d.Add(x1);
            d.Add(x2);
            d.Add(x3);

            //int x = d.Where(e => e.price > 1000000.00).Count();

            //Console.WriteLine(x + " cars with price > 1000000.00");

            {
                while (true)
                {
                    double a, b;
                    
                    try
                    {
                        Console.WriteLine("Spent fuel (litres)");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Kilometrage");
                        b = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error! Wrong format!");
                        continue;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error!");
                        continue;
                    }
                    if (b == 0)
                    {
                        Console.WriteLine("Error! Division by zero!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(a / b * 100 + " litres for 100 km");
                    }
                    break;
                }


                //Buses y = new Buses();

                //y.name = "Man";
                //y.horsepower = 120;
                //y.price = 1870000.80;

                //y.GetInfo();
                //y.Move();
                //y.TrasportingPassengers();

                //Trucks z = new Trucks();

                //z.name = "Kamaz";
                //z.horsepower = 150;
                //z.price = 2000000.30;

                //z.GetInfo();
                //z.Move();
                //z.CargoDelivery();
            }
        }
    }
}
