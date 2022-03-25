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
        private string firstName;
        public void GetInfo()
        {
            firstName = GetValidName("First Name: ");
        }

        private string GetValidName(string message)
        {
            string name;
            do
            {
                Console.Write(message);
                name = Console.ReadLine();
                if (IsValidName(name))
                    return name;
                else
                    Console.WriteLine("Invalid! (First letter caps, Min 3 characters)");
            } while (true);
        }

        private bool IsValidName(string name)
        {
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(name, pattern);
        }
    }
}
