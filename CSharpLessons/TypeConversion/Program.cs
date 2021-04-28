using System;

namespace TypeConversion
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            /* int x = 300;

            byte y = (byte)x;
            */
            
            /*
            string num1 = "1";
            string num2 = "2";

            
            int x = int.Parse(num1);
            int y = int.Parse(num2); 

            int x = Convert.ToInt32(num1);
            int y = Convert.ToInt32(num2);
            */

            
            /*
            int x = 3;
            int y = 4;

            string str1 = x.ToString();
            string str2 = y.ToString();
            



            Console.WriteLine(str1 + str2);

            Console.WriteLine(y.GetType());
            Console.WriteLine(y);


            double num = 9.11;

            int x = Convert.ToInt32(num);
            
            
            
            Console.WriteLine(x);
            Console.WriteLine(num.GetType());

            Console.ReadLine();
            
            

            Console.WriteLine("Enter player Age:");
            string playerAge = Console.ReadLine();

            int playerAgeInt = int.Parse(playerAge);
            int playerAgeInt1 = Convert.ToInt32(playerAge);
            
            
            Console.WriteLine(playerAgeInt);
            Console.WriteLine(playerAgeInt1);

            Console.ReadLine();
            */
            Console.WriteLine("Enter your first integer");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter your second integer");
            string num2 = Console.ReadLine();

            
            
            int xint = int.Parse(num1);
            int yint = int.Parse(num2);
            
            
            
            Console.WriteLine("Total of them is : " + (xint + yint));


            Console.ReadLine();



        }
    }
}