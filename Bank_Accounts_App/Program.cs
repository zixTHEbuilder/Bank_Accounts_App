using Bank_Account_App;
using System.Buffers;

namespace Bank_Accounts_App
{
    class Program
    {
        static void Main()
        {
            Input input = new Input();
            List<BankAccounts> bankAccounts = new List<BankAccounts>();
            while (true)
            {
                Console.WriteLine("Visual Studio Bank");
                int Program_Select = input.ReadInt("Select an Option : \n1. Create Bank Account \n2. Deposit \n3. Withdraw \n4. Check Balance \n5. Exit Program", writeLine: true);
                switch (Program_Select)
                {
                    case 1:
                        {
                            string Owner = input.ReadString("Enter your Full Name");
                            BankAccounts newAccount = new BankAccounts(Owner);
                            bankAccounts.Add(newAccount);

                            Console.WriteLine("Bank Account Created Successfully");
                            foreach (BankAccounts accounts in bankAccounts)
                            {
                                Console.WriteLine(accounts);
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    default:
                        Console.WriteLine("Error - Enter a valid number"); break;
                }
            }
        }
    }
}