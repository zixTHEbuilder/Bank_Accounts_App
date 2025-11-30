using Bank_Accounts_App;
using System.Buffers;
using System.ComponentModel;

namespace Bank_Accounts_App
{
    class Program
    {
        static void Main()
        {
            Input input = new Input();
            Bank bank = new Bank();
            PasswordValidator passwordCreator = new PasswordValidator();

            Console.WriteLine("Visual Studio Bank");
            while (true)
            {
                double Program_Select = input.ReadInt("Select an Option : \n1. Create Bank Account \n2. Deposit \n3. Withdraw \n4. Check Balance \n5. Check Account Details \n6. Exit Program", writeLine: true);
                switch (Program_Select)
                {
                    case 1:
                        {
                            string owner = input.ReadString("Enter your Full Name");
                            string password = passwordCreator.Password();
                            int AccountType = input.ReadInt("Enter account type : \n1. Current Account \n2. Saving Account", writeLine : true);
                            if (AccountType == 1)
                                bank.CreateAccount(owner,password);
                            if (AccountType == 2)
                            {
                                int interestRate = input.ReadInt("Enter the Interest Rate % you want on this account", NumLimit: true);
                                bank.CreateSavingsAccount(owner,password, interestRate);
                            }
                            break;
                        }
                    case 2:
                        {
                            bank.Deposit();
                            break;
                        }
                    case 3:
                        {
                            bank.Withdraw();
                            break;
                        }
                    case 4:
                        {
                            bank.CheckBalance();
                            break;
                        }
                    case 5:
                        {
                            bank.CheckDetails();
                            break;
                        }
                    case 6:
                        {
                            return;
                        }
                    default:
                        Console.WriteLine("Error - Enter a valid number"); break;
                }
            }
        }
    }
}