using System;


namespace moneyPrinter
{
    
    class Program
    {
        static void Loop(BankAccount bankAccount, Client currentUser)
        {
            Console.WriteLine("What would you like to do?  (Withdraw, Deposit, Check, Quit)");
            var reply = Console.ReadLine(); 
            
            switch (reply)
            {
                case "withdraw":
                {
                    Console.WriteLine("How much do you want to withdraw?");
                    var amount = Double.Parse(Console.ReadLine());
                    bankAccount.MakeWithdrawal(amount);
                    Loop(bankAccount,currentUser);
                    break;
                }
                case "deposit":
                {
                    Console.WriteLine("How much are you depositing?");
                    var amount = Double.Parse(Console.ReadLine());
                    bankAccount.MakeDeposit(amount);
                    Loop(bankAccount,currentUser);
                    break;
                }
                case "check":
                {
                    Console.WriteLine("You currently have "+bankAccount.CheckBalance()+ " in your account");
                    Console.WriteLine(" And you joined our bank on " + currentUser.JoinDate+".");
                    Loop(bankAccount,currentUser);
                    break;
                }
                case "quit":
                {
                    Console.WriteLine("we're sad to see you go! Thanks for the money though! Sucker!");
                    break;
                }
                default:
                {
                    Console.WriteLine("don't be an ass select an actual option");
                    Loop(bankAccount, currentUser);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to broke bank! \n Who are you?");
            var name = Console.ReadLine();
            
            
            Console.WriteLine(" What type of account do you have? ");
            var type = Console.ReadLine();
            
            
            Console.WriteLine(" How much money do you have? (please enter a decimal)");
            var initialBalance = Double.Parse(Console.ReadLine());

            
            var currentUser = new Client(1, name);
            var bankAccount = new BankAccount(currentUser,type,initialBalance);
            
            Loop(bankAccount,currentUser);
        }
    }
}