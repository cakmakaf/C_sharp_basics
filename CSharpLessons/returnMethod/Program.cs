using System;

namespace returnMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int returnValue = makeSum(3, 4);


            if (returnValue>5)
            {
                Console.WriteLine("The result is higher then or equal 5" );
            }
            else
            {
                Console.WriteLine("The result is less than or equal 4" );
            }
            
        }

        static int makeSum(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;
        }
    }
}