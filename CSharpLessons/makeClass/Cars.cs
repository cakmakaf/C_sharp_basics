using System;

namespace makeClass
{
    public class Cars
    {
        public int numbeDoor;
        public string carModel;
        public string carColor;


        public Cars()
        {
            Console.WriteLine("Run the constructor method");
        }

        public void startEngine()
        {
            Console.WriteLine("Engine has started");
        }

        public void lockDoors()
        {
            Console.WriteLine("Doors locked");
        }
    }
}