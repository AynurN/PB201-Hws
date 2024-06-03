using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Exeption_Upcasting__downcasting
{
    public class Hotel
    {
        public string Name { get; set; }
        public Room[] Rooms=Array.Empty<Room>();
        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
           Rooms[Rooms.Length- 1]  = room;
        }

        public Room[] GetRooms()
        {
            return Rooms;
        }
        public void MakeReservation(int? roomID) {
            bool flag = false;
            Room? myRoom = null;
            if(Rooms.Length > 0)
            { foreach (var room in Rooms)
            {
                if(room.ID==roomID)
                    { 
                        myRoom = room;
                        flag = true;
                    break;
                }  
            }
            }
            if (flag)
            {
                if (myRoom.IsAvailable)
                {myRoom.IsAvailable = false;
                    Console.WriteLine($"{myRoom.Name} room has successfully reserved");

                }
            
                
            
            else
            
                throw new NotAvailableException($"{myRoom.Name} room is not available now");
            

            }
            else
            {
                throw new NullReferenceException();
            }
           
           
            
           
        }
        public Hotel(string name)
        {
            this.Name = name;
            
        }
    }
}
