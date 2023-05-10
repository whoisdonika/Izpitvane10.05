using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Console.Write("Do you want to add any cars? - ");
            string add = Console.ReadLine();

                while (add == "yes")
                {
                    Car car = new Car();
                    Console.Write("What's the car's brand? - ");
                    string brand = Console.ReadLine();
                    Console.Write("What's the car's model? - ");
                    string model = Console.ReadLine();
                    Console.Write("What's the car's licence plate? - ");
                    string licencePlate = Console.ReadLine();
                    Console.Write("What's the car's year of fabrication? - ");
                    int year = int.Parse(Console.ReadLine());

                    car.Brand = brand;
                    car.Model = model;
                    car.Number = licencePlate;
                    car.Year = year;

                    car.PrintMe();
                    car.EcoOrNot();
                    car.DriveCar();
                     
                    cars.Add(car);

                    Console.Write("Do you want to add any more cars? - ");
                    add = Console.ReadLine();
                }
               if (add == "no")
               {
                Console.WriteLine($"There are {cars.Count} racers.");
                return;
               }




            //Car car1 = new Car("Opel", "Astra", "PB3452AR", 2003);
            //Car car2 = new Car("Wolkswagen", "Golf", "SV7698CD", 2011);
            //Car car3 = new Car("Mercedes", "Benz", "NH3865DH", 2013);

            //car1.PrintMe();
            //car2.PrintMe();
            //car3.PrintMe();

            //Console.WriteLine();

            //car1.EcoOrNot();
            //car2.EcoOrNot();
            //car3.EcoOrNot();

            //Console.WriteLine();

            //car1.DriveCar();
            //car2.DriveCar();
            //car3.DriveCar();

            //Console.WriteLine();




        }
    }
}
