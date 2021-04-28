using System;

namespace IfConditionals
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int grade = 93;

            if (grade>70)
            {
                Console.WriteLine("You passed the class");
                Console.ReadLine();
            }
            
            
            
            else
            {
                Console.WriteLine("You failed the class");
                Console.ReadLine();
            }
        }
    }
}