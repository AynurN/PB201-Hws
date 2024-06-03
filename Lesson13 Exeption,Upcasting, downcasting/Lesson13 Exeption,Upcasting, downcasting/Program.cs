namespace Lesson13_Exeption_Upcasting__downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Room room1 = new Room("Sun", 150, 2);
            //Room room2 = new Room("Moon", 300, 4);
            //Hotel hotel1 = new Hotel("Galactica");
            //hotel1.AddRoom(room1);
            //hotel1.AddRoom(room2);
            //room2.IsAvailable = false;
            //try
            //{
            //    hotel1.MakeReservation(2);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(NotAvailableException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("There is a problem");
            //}
            Car newCar=new Car("Mercedes", "e200", CarType.Sport);
            Car newCar2=new Car("BMW", "m5", CarType.Sport);
            Car newCar3 = new Car("Toyota", "corola", CarType.SUV);
            Console.WriteLine(newCar);
            Console.WriteLine(newCar2);
            Console.WriteLine(newCar3);

        }

    }
}
