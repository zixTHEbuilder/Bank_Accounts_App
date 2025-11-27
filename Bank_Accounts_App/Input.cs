using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Accounts_App
{
    class Input
    {
        public int ReadInt(string message, bool writeLine = false)
        {
            while (true)
            {
                if (writeLine == true)
                    Console.WriteLine(message);
                else
                    Console.Write($"{message} : ");
                string UserInput = Console.ReadLine();
                bool success = int.TryParse(UserInput, out int result);
                if (success == true)
                {
                    return result;
                }
                Console.WriteLine("Invalid Input, Please enter a valid number");
            }
        }
        public decimal ReadDecimal(string message, bool writeLine = false)
        {
            while (true)
            {
                if (writeLine == true)
                    Console.WriteLine(message);
                else
                    Console.Write($"{message} : ");
                string UserInput = Console.ReadLine();
                bool success = decimal.TryParse(UserInput, out decimal result);
                if (success == true)
                {
                    return result;
                }
                Console.WriteLine("Invalid Input, Please enter a valid number");
            }
        }
        public string ReadString(string message)
        {
            while (true)
            {
                Console.Write($"{message} : ");
                return Console.ReadLine();

            }
        }
    }
}
