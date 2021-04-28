using System;

namespace UserInsert
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            
            
            Console.WriteLine("Enter your lastname");
            string lastname = Console.ReadLine();
            
            
            Console.WriteLine("Users' name is: " + name);
            Console.WriteLine("Users' lastname is: " + lastname);

            Console.ReadLine();
        }
    }
}