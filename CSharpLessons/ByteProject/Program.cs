using System;
using System.Xml;

namespace ByteProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte first = 5;
            byte second = 13;
            byte third = 100; // byte characters are only from 0 to 255


            byte highestValue = byte.MaxValue;
            byte lowestValue = byte.MinValue;
            
            
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            
            Console.WriteLine(highestValue);
            Console.WriteLine(lowestValue);
            
            
            Console.ReadLine();
        }
    }
}