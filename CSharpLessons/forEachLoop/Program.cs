using System;

namespace forEachLoop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // string[] fruits = {"Apple", "Banana", "Coconut", "Date Fruit", "Elderberry"};
            //
            // foreach (var item in fruits)
            // {
            //     Console.WriteLine(item);
            // }
            
            double[] calories = {95.34, 105.20, 10405.18, 414.5, 99.78};

            foreach (var x in calories)
            {
                Console.WriteLine(x);
            }
            

            Console.ReadLine();

        }
    }
}