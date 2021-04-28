using System;
using System.Xml;

namespace AppATM
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int balance = 5500;
            
            // Ask what the customer wants to do
            //1- Balance Inquiry
            //2- Balance Withdrawal
            //3- Balance Deposit
            //Enter x for exit.
            Console.WriteLine("Welcome to Bank of A");
            Console.WriteLine("Please select your transaction");
            string selection = Console.ReadLine();


            if (selection == "1")
            {
                Console.WriteLine("Currnet Balance is: "+ balance);
                Console.ReadLine();
            }
            else if (selection == "2")
            {
                Console.WriteLine("Enter the amount of withdrawal you want to make");
                int withdrawalAmount = Convert.ToInt32(Console.ReadLine());

                if (withdrawalAmount < balance)
                {
                    Console.WriteLine("Remaining balance is: "+(balance-withdrawalAmount));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter a valid amount ");
                    Console.ReadLine();
                }
                
            }
            else if (selection == "3")
            {
                Console.WriteLine("Enter the amount of deposit you want to make");
                int depositAmount = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Current balance is: "+(balance + depositAmount));
                Console.ReadLine();
                
            }
            else if (selection == "x")
            {
                Console.WriteLine("Exiting from Bank of A ATM");
                Console.WriteLine("Exit is successful");
                Console.WriteLine("See you next time :)");
                Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("Enter a valid key to proceed");
                Console.ReadLine();
            }
        }
    }
}