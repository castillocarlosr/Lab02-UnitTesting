using System;

namespace Lab02_UnitTesting
{
    class Program
    {
        public static decimal balance = 5000m;

        public static void Main(string[] args)
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
                    ViewBalance(balance);
                }
                else if(inputChoice == "2")
                {
                    WithdrawMoney();
                }
                else if(inputChoice == "3")
                {
                    DepositMoney();
                }
                else if(inputChoice == "4")
                {
                    ExitATM();
                }
            }
            catch (Exception )
            {

                throw;
            }
        }

        public static decimal ViewBalance(decimal insideBalance)
        {
            decimal currentBalance = balance;
            Console.WriteLine($"${balance}");
            Console.ReadLine();
            
            return balance;

        }

        public static decimal WithdrawMoney()
        {
            decimal currentBalance = balance;
            Console.Write("How much money do you want to WITHDRAW: $");
            string inputWithdraw = Console.ReadLine();
            decimal inputWithdrawDecimal = decimal.Parse(inputWithdraw);

            balance = currentBalance - inputWithdrawDecimal;
            //AppDomain();
            return balance;
        }

        public static decimal DepositMoney()
        {
            decimal currentBalance = balance;
            Console.Write("How much money do you want to DEPOSIT: $");
            string inputDeposit = Console.ReadLine();
            decimal inputDepositDecimal = decimal.Parse(inputDeposit);

            balance = currentBalance + inputDepositDecimal;
            return balance;
        }

        public static bool ExitATM()
        {
            return false;
        }

    }
}
