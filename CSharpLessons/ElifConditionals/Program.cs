using System;
using System.Xml;

namespace ElifConditionals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your first score");
            int firstGrade = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter your second score");
            int secondGrade = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter your third score");
            int thirdGrade = Convert.ToInt32(Console.ReadLine());


            int averageGrade = (firstGrade + secondGrade + thirdGrade) / 3;


            if (averageGrade >=90 && averageGrade <= 100)
            {
                Console.WriteLine("Your Final Grade is: A");
            }
            else if (averageGrade >=80 && averageGrade <= 89)
            {
                Console.WriteLine("Your Final Grade is: B");
            }
            else if (averageGrade >=70 && averageGrade <= 79)
            {
                Console.WriteLine("Your Final Grade is: C");
            }
            else if (averageGrade >= 60 && averageGrade <= 69)
            {
                Console.WriteLine("Your Final Grade is: D");
            }
            else
            {
                Console.WriteLine("Your Final Grade is: F");
            }
        }
    }
}