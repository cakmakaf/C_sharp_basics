using System;

namespace forLoops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
            

            for (int i = 0; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            for (int i = 1; i <=10 ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}