using System;

namespace Arrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // int[] nums = new int[4];
            //
            // nums[0] = 1;
            // nums[1] = 11;
            // nums[2] = 21;
            // nums[3] = 31;
            //
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     Console.WriteLine(nums[i]);
            // }
            //
            // Console.ReadLine();

            string[] fruits = {"Apple", "Banana", "Coconut", "Date Fruit", "Elderberry"};

            double[] calories = {95.34, 105.20, 10405.18, 414.5, 99.78};

            char[] vitamins = {'A', 'B', 'C', 'D', 'E'};
            
            
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.ReadLine();
            
            
            
            for (int i = 0; i < calories.Length; i++)
            {
                Console.WriteLine(calories[i]);
            }
            Console.ReadLine();
            
            

            for (int i = 0; i < vitamins.Length; i++)
            {
                Console.WriteLine(vitamins[i]);
            }
            Console.ReadLine();


        }
    }
}