using System;

namespace makeClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Cars car1 = new Cars();

            car1.numbeDoor = 4;
            car1.carColor = "Black";
            car1.carModel = "Mercedes";
            
            car1.lockDoors();
            car1.startEngine();
            
            Console.WriteLine("Nuber of the doors : "+ car1.numbeDoor);
            Console.WriteLine("The color is :"+ car1.carColor);
            Console.WriteLine("The model of the var is : "+ car1.carModel);
        }
    }
}