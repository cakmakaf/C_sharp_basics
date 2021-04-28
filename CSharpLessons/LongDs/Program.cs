using System;

namespace LongDs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            long firstVal = 4344400234244;
            long secondVal = -43543564536768;

            long highestVal = long.MaxValue;
            long lowestVal = long.MinValue;
            
            
            Console.WriteLine(firstVal);
            Console.WriteLine(secondVal);
            Console.WriteLine(highestVal);
            Console.WriteLine(lowestVal);

            Console.ReadLine();
        }
    }
}