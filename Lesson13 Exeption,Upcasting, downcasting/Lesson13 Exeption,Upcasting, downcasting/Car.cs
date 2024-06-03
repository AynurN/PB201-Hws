using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Exeption_Upcasting__downcasting
{
    public class Car
    {   private static int _id=0;
        public int ID { get; private  set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public CarType Type { get; set; }
        public Car()
        {
            ++_id;
            ID = _id;
        }
        public Car(string brand, string model, CarType type):this()
        {
            Brand = brand;
            Model = model;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Brand}-{Model}-{Type}-{ID}";
        }
    }
}
