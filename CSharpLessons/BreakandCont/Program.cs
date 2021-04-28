using System;

namespace BreakandCont
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i++)
            {
                if (i==5)
                {
                    continue;
                }
                Console.WriteLine("the value is " + i);
            }

            Console.ReadLine();
        }
    }
}