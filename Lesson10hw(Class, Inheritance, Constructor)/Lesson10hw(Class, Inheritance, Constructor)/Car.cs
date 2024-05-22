using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10hw_Class__Inheritance__Constructor_
{//Task2
    internal class Car
    {
        public string Brand;
        public string Model;
        public int CurrentFuel;
        public int FuelFor1Km;
        public int Millage;
        
        public void Drive(int km)
        {
            if (CurrentFuel - FuelFor1Km * km > 0)
            {
                CurrentFuel-= FuelFor1Km * km;
                Millage += km;
            }
            else
            {
                Console.WriteLine("There is not enough fuel");
            }
        }
        public void ShowAllProperities()
        {
            Console.WriteLine($"Brand:{Brand}, Model:{Model}, CurrentFuel:{CurrentFuel}, FuleFor1Km:{FuelFor1Km}, Millage:{Millage}");
        }
    }
}
