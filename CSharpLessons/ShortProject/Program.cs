using System;

namespace ShortProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            short firstValue = -3;
            short secondValue = 12345;
            short thirdValue = 5000;
            short highestValue = short.MaxValue;
            short lowestValue = short.MinValue;
            
            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
            Console.WriteLine(thirdValue);
            Console.WriteLine(highestValue);
            Console.WriteLine(lowestValue);

            Console.ReadLine();
        }
    }
}