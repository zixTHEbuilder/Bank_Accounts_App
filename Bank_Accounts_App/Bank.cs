using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Security.Principal;
using System.Text;

namespace Bank_Accounts_App
{
    class Bank
    {
        private readonly List<BankAccount> accounts = new List<BankAccount>();
        private readonly Input input = new Input();
        private readonly PasswordValidator password = new PasswordValidator();
        public void CreateAccount()
        {
            string owner = input.ReadString("Name");
            string passwordCreate = password.CreatePassword();
            int type = input.ReadInt("Enter Account Type :\n1. Current\n2. Savings", writeLine: true);

            if (type == 1)
                accounts.Add(new BankAccount(owner, passwordCreate));

            if (type == 2)
            {
                decimal interestRate = input.ReadDecimal("Enter Interest Rate %", NumLimit: true);
                accounts.Add(new SavingsAccount(owner, passwordCreate, interestRate));
            }
            else
                Console.WriteLine("Invalid Input");
        }
        public void Deposit()
        {
            var ChosenAccount = selectAccount();
            if (ChosenAccount == null) return;

            decimal amount = input.ReadDecimal("Enter amount to deposit");
            Console.WriteLine(ChosenAccount.Deposit(amount));
        }
        public void Withdraw()
        {
            var ChosenAccount = selectAccount();
            if (ChosenAccount == null) return;
            if (!validatePassword(ChosenAccount)) return;

            decimal amount = input.ReadDecimal("Enter amount to withdraw");
            Console.WriteLine(ChosenAccount.Withdraw(amount));

        }
        public void CheckBalance()
        {
            var ChosenAccount = selectAccount();
            if (ChosenAccount == null) return;
            Console.WriteLine(ChosenAccount.Balance);

        }
        public void CheckDetails()
        {
            var ChosenAccount = selectAccount();
            if (ChosenAccount == null) return;
            if (!validatePassword(ChosenAccount)) return; // if validate password return true, it'll move on to next otherwise it'll return

            Console.WriteLine(ChosenAccount);
        }
        private BankAccount selectAccount()
        {
            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts found"); return null;
            }
            for (int i = 0; i < accounts.Count; i++)
                Console.WriteLine($"{i + 1}. {accounts[i].Owner}");

            int AccountSelect = input.ReadInt("Choose an account");

            if (AccountSelect < 0 && AccountSelect < accounts.Count)
            {
                Console.WriteLine("Invalid Account");
                return null;
            }
            return accounts[AccountSelect - 1];
        }
        private bool validatePassword(BankAccount Account)
        {
            for (int i = 0; i < 3; i++)
            {
                string passwordCheck = input.ReadString("Enter your password");
                if (passwordCheck == Account.Password)
                    return true;

                Console.WriteLine("Invalid Password");
            }
            Console.WriteLine("Maximum attempts reached!");
            return false;
        }
    }
}
