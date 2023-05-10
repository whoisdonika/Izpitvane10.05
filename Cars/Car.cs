using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Car
    {
		private string brand;

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private string number;

		public string Number
		{
			get { return number; }
			set { number = value; }
		}

		private int year;

		public int Year
		{
			get { return year; }
			set 
			{
				if (value > 1768)
				{
                   year = value;
					
				
				}
				else
				{
					Console.Write("Invalid value for the car's year. Try again!");
					year = 0;
				}
				
			}
		}

		public void EcoOrNot()
		{
            if (this.Year > 2000)
            {
                Console.WriteLine($"{this.Brand} {this.Model} : I am an ECO car :)");
            }
            else
            {
                Console.WriteLine($"{this.Brand} {this.Model} : I am not an ECO car :(");
            }
        }
		public void DriveCar()
		{
			Console.WriteLine($"{this.Brand} {this.Model} : Brum-brum-brum!");
		}

		public void PrintMe()
		{
			Console.WriteLine($"Brand : {this.Brand}, Model : {this.Model}, Number : {this.Number} Year : {this.Year}");
		}
       
		private static int counter;
        public static int Counter
        {
			get { return counter;}
        }

		//public Car(string brand, string model, string number, int year)
		//{
		//	this.brand = brand;
		//	this.model = model;
		//	this.number = number;
		//	this.year = year;

		//	counter++;


		//}

		






	}
}
