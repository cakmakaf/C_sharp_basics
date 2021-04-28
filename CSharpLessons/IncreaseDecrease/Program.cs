using System;

namespace IncreaseDecrease
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int num1 = 17;
            int num2 = 5;

            //num1++;
            num1--;

            int num3 = 17;

            bool check = num1 == num3;
            bool check2 = num1 != num2;

            int age = 35;

            bool check3 = age > 40;
            bool check4 = age <= 40;
            
            Console.WriteLine(check);
            Console.WriteLine(check2);
            Console.WriteLine(check3);
            Console.WriteLine(check4);
            //Console.WriteLine(num1);

            Console.ReadLine();
        }
    }
}