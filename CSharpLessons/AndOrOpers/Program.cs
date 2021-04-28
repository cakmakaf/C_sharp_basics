using System;

namespace AndOrOpers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 3;
            
            int num2 = 3;

            int num3 = 5;

            bool check1 = num1 == num2 && num1 < num3;
            
            bool check2 = num1 == num2 || num1 > num3;
            
            
            
            Console.WriteLine(check1);
            Console.WriteLine(check2);
            Console.ReadLine();
        }
    }
}