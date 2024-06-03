using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Exeption_Upcasting__downcasting
{
    public class Room
    { private static int _count = 0;
        private bool _isAvailable = true;
        public  int ID { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get { return _isAvailable; } set { _isAvailable = value; }
        }

        public string ShowInfo()
        {
            return ($"{Name}- {ID}- {Price} -{PersonCapacity} -{IsAvailable}");
        }
      
        public Room(string name, double price, int personCapacity)
        {
            this.Name = name;
            this.Price = price;
            this.PersonCapacity = personCapacity;
            ++_count;
            ID = _count;

        }
        
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
