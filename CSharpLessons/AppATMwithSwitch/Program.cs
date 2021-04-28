using System;

namespace AppATMwithSwitch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int balance = 5500;
            
            Console.WriteLine("Welcome to Bank of A");
            Console.WriteLine("Please select an option");
            Console.WriteLine("1- Balance Inquiry");
            Console.WriteLine("2- Balance Withdrawal");
            Console.WriteLine("3- Balance Deposit");
            Console.WriteLine("4- Exit");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    Console.WriteLine("Your Balance is: " + balance);
                    Console.ReadLine();
                    break;
                
                case "2":
                    Console.WriteLine("Enter the amount to withdraw");
                    int withdrawalAmount = Convert.ToInt32(Console.ReadLine());

                    if (withdrawalAmount > balance)
                    {
                        Console.WriteLine("Enter a valid amount");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Remaining balance is: " + (balance - withdrawalAmount));
                        Console.ReadLine();
                    }
                    break;
                
                case "3":
                    Console.WriteLine("Enter the amount to deposit");
                    int depositAmount = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Your new Balance is: "+ (balance + depositAmount));
                    Console.ReadLine();
                    break;
                
                case "4":
                    Console.WriteLine("Exit from ATM");
                    Console.WriteLine("Have a great day :)");
                    Console.ReadLine();
                    break;
                
                default:
                    Console.WriteLine("Please enter a valid key");
                    Console.ReadLine();
                    break;
            }
            
            
        }
    }
}