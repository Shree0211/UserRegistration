using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class RegistrationForm
    {
        private const string namePattern = @"^[A-Z][a-zA-Z]{2,}$";
        private const string emailPattern = @"^[A-Za-z0-9]{3,}([.][A-Za-z0-9]{3,})?[@][a-zA-Z]{2,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2})?$";

        private string firstName;
        private string lastName;
        private string email;

        public void GetInfo()
        {
            firstName = GetValidInfo("First Name: ", namePattern);
            lastName = GetValidInfo("Last Name: ", namePattern);
            email = GetValidInfo("Email: ", emailPattern);
        }

        private static string GetValidInfo(string message, string pattern)
        {
            string info;
            do
            {
                Console.Write(message);
                info = Console.ReadLine();
                if (IsValid(info, pattern))
                    return info;
                else
                    Console.WriteLine("Invalid!");
            } while (true);
        }

        private static bool IsValid(string info, string pattern)
        {
            return Regex.IsMatch(info, pattern);
        }
    }
}
