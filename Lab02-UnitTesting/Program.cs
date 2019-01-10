using System;

namespace Lab02_UnitTesting
{
    public class Program
    {
        //example starter balance
        public static decimal balance = 5000m;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Code401 ATM");
            Console.WriteLine("\n");
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        // bool to give options for ATM
        public static bool MainMenu()
        {
            Console.WriteLine("Choose an option you would like to make:");
            Console.WriteLine("1) View Balance:");
            Console.WriteLine("2) Withdraw Money:");
            Console.WriteLine("3) Deposit Money:");
            Console.WriteLine("4) Exit ATM:");

            string inputChoice = Console.ReadLine();

            try
            {
                if (inputChoice == "1")
                {
                    ViewBalance(balance);
                    return true;
                }
                else if (inputChoice == "2")
                {
                    WithdrawMoney();
                    return true;
                }
                else if (inputChoice == "3")
                {
                    DepositMoney();
                    return true;
                }
                else if (inputChoice == "4")
                {
                    return false;
                }
            }
            catch (Exception all)
            {
                Console.WriteLine("Looks like you didn't type a valid option");
                Console.WriteLine(all.Message);
                Console.ReadLine();
                throw;
            }
            return true;
        }

        //Just to view current balamce
        public static decimal ViewBalance(decimal insideBalance)
        {
            try
            {
                decimal currentBalance = balance;
                Console.WriteLine($"${balance}");
                Console.WriteLine("Press ENTER to return to Main ATM Menu.");
                Console.ReadLine();
                return balance;
            }
            catch (Exception all)
            {
                Console.WriteLine("Looks you typed text instead of numbers.");
                Console.WriteLine(all.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Thank you for using our ATM :)");
                Console.ReadLine();
            }


        }

        //Console display to ask user how much to withdraw and reord user input
        public static decimal WithdrawMoney()
        {
            try
            {
                decimal currentBalance = balance;
                Console.Write("How much money do you want to WITHDRAW: $");
                string inputWithdraw = Console.ReadLine();
                decimal inputWithdrawDecimal = decimal.Parse(inputWithdraw);
                WithdrawInput(inputWithdrawDecimal);
            }
            catch (Exception all)
            {
                Console.WriteLine("ATM only handles numbers.  Not letters.");
                Console.WriteLine(all.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Thank you for using our ATM :)");
                Console.ReadLine();
            }

            return balance;
        }

        //This is where that user input goes into to subtract from balance.  Negative number will ask user to try again.
        public static decimal WithdrawInput(decimal insideValue)
        {
            decimal currentBalance = balance;
            if (insideValue < 0)
            {
                Console.WriteLine("Nice try.  You can't negative a withdraw.");
                Console.WriteLine("");
            }
            else if ((currentBalance - insideValue) > 0)
            {
                balance = currentBalance - insideValue;
                Console.WriteLine($"You have withdrawn ${insideValue}");
                Console.WriteLine("");
                return balance;
            }
            else
            {
                Console.WriteLine("Sorry.  You do NOT have that much money!");
                Console.WriteLine($"Your current balance is ${currentBalance}");
                Console.WriteLine("");
                return currentBalance;
            }
            return 0;
        }

        //This is to ask user for how much to deposit and record user input
        public static decimal DepositMoney()
        {
            try
            {
                decimal currentBalance = balance;
                Console.Write("How much money do you want to DEPOSIT: $");
                string inputDeposit = Console.ReadLine();
                decimal inputDepositDecimal = decimal.Parse(inputDeposit);
                DepositMoneyInput(inputDepositDecimal);
            }
            catch (Exception all)
            {
                Console.WriteLine("Looks you typed text instead of numbers.");
                Console.WriteLine(all.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Thank you for using our ATM :)");
                Console.ReadLine();
            }

            return balance;
        }

        //This is where the user input adds to the current balance.  Again negative number will ask user to try again.
        public static decimal DepositMoneyInput(decimal insideValue)
        {
            decimal currentBalance = balance;
            if (insideValue < 0)
            {
                Console.WriteLine("Nice try.  You can't negative a deposit.");
                Console.WriteLine("");
                return balance;
            }
            else
            {
                balance = currentBalance + insideValue;
                Console.WriteLine($"You have deposited ${insideValue}");
                Console.WriteLine("");
                return balance;
            }
        }
    }
}
