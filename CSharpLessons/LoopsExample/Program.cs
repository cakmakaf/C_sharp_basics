using System;

namespace LoopsExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number");

            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                sum += i;
            }

            double average = sum / num;

            if (average >= 80)
            {
                Console.WriteLine("The average score is higher than 80...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The average is less than 80");
                Console.ReadLine();
            }
        }
    }
}