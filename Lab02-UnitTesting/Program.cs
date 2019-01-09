using System;

namespace Lab02_UnitTesting
{
    class Program
    {
        public static decimal balance = 5000m;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Code401 ATM");
            Console.WriteLine("\n");
            Console.WriteLine("Choose an option you would like to make:");
            Console.WriteLine("1) View Balance:");
            Console.WriteLine("2) Withdraw Money:");
            Console.WriteLine("3) Deposit Money:");
            Console.WriteLine("");
            Console.WriteLine("4) Exit ATM:");

            string inputChoice = Console.ReadLine();

            try
            {
                if(inputChoice == "1")
                {
                    ViewBalance();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static decimal ViewBalance()
        {
            Console.WriteLine(balance);
            Console.ReadLine();
            return balance;
        }

    }
}
