using System;

namespace HelloDotnet
{
    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmationPassword { get; set; }
    }

    class PasswordMismatchException : Exception
    {
        public PasswordMismatchException(string message) : base(message)
        {
        }
    }

    class Program
    {
        public static User ValidatePassword(string name, string password, string confirmationPassword)
        {
            if (password != confirmationPassword)
            {
                throw new PasswordMismatchException("Password entered does not match");
            }

            User user = new User
            {
                Name = name,
                Password = password,
                ConfirmationPassword = confirmationPassword
            };

            return user;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Password:");
                string password = Console.ReadLine();

                Console.WriteLine("Enter Confirm Password:");
                string confirmPassword = Console.ReadLine();

                User user = ValidatePassword(name, password, confirmPassword);
                Console.WriteLine("Registered Successfully");
            }
            catch (PasswordMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
