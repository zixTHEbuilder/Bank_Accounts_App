using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Bank_Accounts_App
{
    class BankAccounts
    {
        Input input = new Input();

        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }        // when u change "set" to "private set" only the class can modifiy the balance, certain rules can be used to make sure the values are being set only after they comply with the rules.
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
        public string Deposit(decimal amount)
        {
            if (amount <= 0)
                return $"{amount}$ Cannot Be Deposited.";
            if (amount > 10000)
                return "AML Deposit Limit Reached!";
            Balance += amount;
            return $"{amount} Deposited Successfully";
        }
        public string Withdraw(decimal amount)
        {
            if (amount  <= 0)
                return $"{amount}$ Cannot Be Withdrawn";
            if (amount > Balance)
                return "You Don't Have Enough Balance!";
            Balance -= amount;
            return $"{amount} Withdrawn Successfully";
        }
    }
}
