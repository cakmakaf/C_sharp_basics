using System;

namespace MthodAdd
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //summation(5,95);
            
            //multiply(3,4,5);

            printName("Ahmet", "C");

            Console.ReadLine();
        }

        static void summation(int num1, int num2)
        {
            Console.WriteLine("The sum of two integers is " + (num1 + num2));
            Console.ReadLine();
        }

        static void multiply(int num1, int num2, int num3)
        {
            Console.WriteLine("The product of the integers is "+ (num1 * num2 * num3));
            Console.ReadLine();
        }

        static void printName(string name, string lastname)
        {
            Console.WriteLine("The users name is "+ name + " "+ lastname);
        }
        
    }
}