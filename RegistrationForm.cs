using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class RegistrationForm
    {
        const string namePattern = @"^[A-Z][a-zA-Z]{2,}$";
        const string emailPattern = @"^[A-Za-z0-9]{3,}([.][A-Za-z0-9]{3,})?[@][a-zA-Z]{2,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2})?$";
        const string mobilePattern = @"^[0-9]{2}[ ][0-9]{10}$";

        private string firstName;
        private string lastName;
        private string email;
        private string mobile;

        public void GetInfo()
        {
            firstName = GetValidInfo("First Name: ", namePattern);
            lastName = GetValidInfo("Last Name: ", namePattern);
            email = GetValidInfo("Email: ", emailPattern);
            mobile = GetValidInfo("Mobile: ", mobilePattern);
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
