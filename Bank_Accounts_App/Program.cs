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
            while (true)
            {
                Console.WriteLine("Visual Studio Bank");
                double Program_Select = input.ReadInt("Select an Option : \n1. Create Bank Account \n2. Deposit \n3. Withdraw \n4. Check Balance \n5. Check Account Details \n6. Exit Program", writeLine: true);
                switch (Program_Select)
                {
                    case 1:
                        {
                            string owner = input.ReadString("Enter your Full Name");
                            string password = input.Password();
                            bank.CreateAccount(owner,password);
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