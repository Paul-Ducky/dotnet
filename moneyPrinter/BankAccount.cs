using System;

namespace moneyPrinter
{
    public class BankAccount
    {
        private Client client { get; }
        private string type { get; set; } 
        private double balance { get; set; }

        public double CheckBalance()
        {
            return balance;
        }
        
        public void MakeDeposit(double amount)
        {
            balance += amount;
            Console.WriteLine("you deposit "+amount+" to your account. ");
        }
        public void MakeWithdrawal(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("A negative balance is not allowed!");
                Console.WriteLine("You have " + balance + " remaining in your account. Sucker...");
            }else if (amount == balance)
            {
                Console.WriteLine("Are you sure you want to empty your account?");
                var answer = Console.ReadLine();
                if (answer == "yes")
                {
                    balance -= amount; 
                    Console.WriteLine("We're sorry to see you go");
                }
            }
            else
            {
                balance -= amount;    
                Console.WriteLine("You withdraw " + amount + " from your account.");
            }
            
        }

        public BankAccount(Client client,string type, double initialBalance)
        {
            this.client = client;
            this.type = type;
            balance = initialBalance;
        }
    }
}