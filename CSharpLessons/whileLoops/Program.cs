using System;

namespace whileLoops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*int x = 3;

            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }

            Console.ReadLine();
            
            int x = 300;

            while (x >= 100)
            {
                Console.WriteLine(x);
                x *= 5;
            }

            Console.ReadLine();
            

            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x<=10);

            Console.ReadLine();
            */

            int x = 1;

            int sum = 0;

            do
            {
                sum += x;
                x++;
            } while (x<=100);
            
            Console.WriteLine("The total is: "+ sum);

            Console.ReadLine();

        }
    }
}