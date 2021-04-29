using System;

namespace ArrayExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[4];
            
            // nums[0] = 1;
            // nums[1] = 11;
            // nums[2] = 21;
            // nums[3] = 31;
            
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Enter the value of "+(i+1)+". index : ");

                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            
            Console.ReadLine();
        }
    }
}