using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class RegistrationForm
    {
        const string namePattern = @"^[A-Z][a-zA-Z]{2,}$";
        const string emailPattern = @"^[A-Za-z0-9]{3,}([.][A-Za-z0-9]{3,})?[@][a-zA-Z]{2,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2})?$";
        const string mobilePattern = @"^[0-9]{2}[ ][0-9]{10}$";
        const string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,10}$";

        private string firstName;
        private string lastName;
        private string email;
        private string mobile;
        private string password;


        public void GetInfo()
        {
            firstName = GetValidInfo("First Name: ", namePattern);
            lastName = GetValidInfo("Last Name: ", namePattern);
            email = GetValidInfo("Email: ", emailPattern);
            mobile = GetValidInfo("Mobile: ", mobilePattern);
            password = GetValidInfo("Password: ", passwordPattern);

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
        public static void SampleEmail()
        {
            string[] info ={"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc-100@abc.net","abc111@abc.com","abc+100@gmail.com",
                                   "abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc","abc@.com.my","abc123@gmail.a","abc123@.com",
                                   "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@gmail.com.1a",
                                   "abc@gmail.com.aa.au","abc..2002@gmail.com"};

            Console.WriteLine("Validate Sample Email Id");
        }
        private static bool IsValid(string info, string pattern)
        {
            return Regex.IsMatch(info, pattern);
        }
    }
}