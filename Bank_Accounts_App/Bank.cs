using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Accounts_App
{
    class Bank
    {
        Input input = new Input();
        List<BankAccounts> bankAccounts = new List<BankAccounts>();
        public void CreateAccount(string Owner, string password)
        {
            BankAccounts newAccount = new BankAccounts(Owner, password);
            bankAccounts.Add(newAccount);

            Console.WriteLine("Bank Account Created Successfully");
        }
        public void Deposit()
        {
            for (int i = 0; i < bankAccounts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bankAccounts[i].Owner}");
            }
            Console.WriteLine();

            int selectedAccount = input.ReadInt("Select the bank account in which you want to deposit money");
            if (selectedAccount > 0 && selectedAccount <= bankAccounts.Count)
            {
                decimal amount = input.ReadDecimal("Enter the amount you want to deposit");
                bankAccounts[selectedAccount - 1].Deposit(amount);     // u cannot change the values directly because the Balance setter is set to private so u use the .Deposit so that the function inside the class can change it since thats the only class that can change it when its set to private.
                return;
            }
            Console.WriteLine("Account doesn't exist, please enter a valid number to select the account");
        }
        public void Withdraw()
        {
            for (int i = 0; i < bankAccounts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bankAccounts[i].Owner}");
            }
            Console.WriteLine();

            int selectedAccount = input.ReadInt("Select the bank account from which you want to withdraw money");
            if (selectedAccount > 0 && selectedAccount <= bankAccounts.Count)
            {
                decimal amount = input.ReadDecimal("Enter the amount you want to Withdraw");
                bankAccounts[selectedAccount - 1].Withdraw(amount);
                return;
            }
            Console.WriteLine("Account doesn't exist, please enter a valid number to select the account");
        }
        public void CheckBalance()
        {
            for (int i = 0; i < bankAccounts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bankAccounts[i].Owner}");
            }
            Console.WriteLine();

            int selectedAccount = input.ReadInt("Select the account whose balance you want to check");
            if (selectedAccount > 0 && selectedAccount <= bankAccounts.Count)
            {
                Console.WriteLine($"Balance : {bankAccounts[selectedAccount - 1].Balance}");
                return;
            }
            Console.WriteLine("Account doesn't exist, please enter a valid number to select the account");
        }
        public void CheckDetails()
        {
            for (int i = 0; i < bankAccounts.Count; i++)
            {
                Console.WriteLine($"{i+1}. {bankAccounts[i].Owner}");
            }
            Console.WriteLine();

            int selectedAccount = input.ReadInt("Choose an account to procceed");
            if (selectedAccount > 0 && selectedAccount <= bankAccounts.Count)
            {
                var account = bankAccounts[selectedAccount - 1];
                for (int i = 0; i < 3; i++)
                {
                    string passwordCheck = input.ReadString("Enter your password");
                    if (passwordCheck == account.Password)
                    {
                        Console.WriteLine();
                        Console.WriteLine(account);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Password doesn't match");
                    }
                }
                Console.WriteLine("Password Attempts Reached");
            }
        }
    }
}
