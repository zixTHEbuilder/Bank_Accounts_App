using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Accounts_App
{
    class PasswordValidator
    {
        public string CreatePassword()
        {
            Input input = new Input();
            string password;
            while (true)
            {
                password = input.ReadString("Enter a password containing 6-12 characters ");
                string passwordConfirmation = input.ReadString("Confirm Password");
                if (string.IsNullOrEmpty(password) && string.IsNullOrEmpty(passwordConfirmation))
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
