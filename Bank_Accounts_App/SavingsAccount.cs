using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Accounts_App
{
    class SavingsAccount : BankAccount
    {
        public decimal InterestRate {  get; set; }
        public SavingsAccount(string owner, string password, decimal interestRate) : base(owner +"(SA)", password) // each class must define its own constructor properties and also make sure the given names match the arguement given is same as "base(owner)" . Also (SA) can be added not where you type arguements but inside the constructor where u define parameters.
        {
            InterestRate = interestRate;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nInterest Rate :  {InterestRate.ToString()}%";
        }
    }
}
