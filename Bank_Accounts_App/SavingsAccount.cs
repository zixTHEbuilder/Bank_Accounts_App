using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Accounts_App
{
    class SavingsAccount : BankAccount
    {
        public decimal InterestRate {  get; set; }
        public SavingsAccount(string owner, string password, decimal interestRate) : base(owner + $"({interestRate}%)", password) // each class must define its own constructor properties and also make sure the given names match the argument given is same as "base(owner)" . Also (SA) can be added not where you type arguments but inside the constructor where u define parameters.
        {
            InterestRate = interestRate;
        }
        public override string Deposit(decimal amount)  // u used "virtual" keyword in the parent class / original "deposit" method so now u have to use "override" here so it knows u want to override the method that has "virtual" in the parent class.
        {
            if (amount <= 0)
                return $"{amount}$ Cannot Be Deposited.";
            if (amount > 10000)
                return "AML ( Anti - Money Laundering ) Deposit Limit Reached!";
            decimal interestAmount = (InterestRate / 100) * amount;     // this is the formula for calculating interest amount when depositing using Polymorphism.
            Balance += amount + (interestAmount);       // remember to add the "+(interest amount) so that the interest amount gets added when depositing.
            return $"{amount}$ Deposited with interest";
        }
        public override string ToString()
        {
            return base.ToString() + $"\nInterest Rate :  {InterestRate.ToString()}%";
        }
    }
}
