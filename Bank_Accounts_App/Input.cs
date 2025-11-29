using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public string Password()
        {
            Input input = new Input();
            string password;
            while (true)
            {
                password = input.ReadString("Enter a password containing 6-12 characters ");
                string passwordConfirmation = input.ReadString("Confirm Password");
                if (string.IsNullOrEmpty(password)&& string.IsNullOrEmpty(passwordConfirmation))
                {
                    Console.WriteLine("Password cannnot be empty");
                    continue;
                }
                if (password.Length < 6 || password.Length > 12)
                {
                    Console.WriteLine("Password must 6-12 characters only");
                    continue;
                }
                if (password != passwordConfirmation)
                {
                    Console.WriteLine("Passwords do not match");
                    continue;
                }
                return password;
            }
        }
    }
}
