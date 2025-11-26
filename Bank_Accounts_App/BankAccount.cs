using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Accounts_App
{
    class BankAccounts
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccounts(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }
        public override string ToString()
        {
            return $"Account Name : {Owner} - Account Balance : {Balance} \nAccount Number : {AccountNumber}";
        }
    }
}
