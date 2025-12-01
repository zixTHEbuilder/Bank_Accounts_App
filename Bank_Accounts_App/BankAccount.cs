using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Transactions;

namespace Bank_Accounts_App
{
    class BankAccount
    {

        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }        // when u change "set" to "private set" only the class can modify the balance, certain rules can be used to make sure the values are being set only after they comply with the rules.
        public string Password { get; set; }            // u can use "protected set" instead of "private set" so that it allows modification by its own class (obviously) and its child (derived) classes , not anywhere else.
        public BankAccount(string owner , string password)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
            Password = password;
        }
        public override string ToString()
        {
            return $"Account Name : {Owner} - Account Balance : {Balance} \nAccount Number : {AccountNumber}";
        }
        public virtual string Deposit(decimal amount)       // use "virtual" so that if the child class provides its own deposit method, it'll use that version / child can override it. if child class create any method then it'll use this method as default.
        {
            if (amount <= 0)
                return $"{amount}$ Cannot Be Deposited.";
            if (amount > 10000)
                return "AML ( Anti - Money Laundering ) Deposit Limit Reached!";
            Balance += amount;
            return $"{amount}$ Deposited Successfully";
        }
        public string Withdraw(decimal amount)
        {
            if (amount  <= 0)
                return $"{amount}$ Cannot Be Withdrawn";
            if (amount > Balance)
                return "You Don't Have Enough Balance!";
            Balance -= amount;
            return $"{amount}$ Withdrawn Successfully";
        }
    }
}
