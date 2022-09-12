using System;

namespace _04PasswordValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Password Validation
            //Create a program that checks if a given password is valid.
            //            The password validation rules are:
            //    • It should contain 6 – 10 characters(inclusive)
            //    • It should contain only letters and digits
            //    • It should contain at least 2 digits
            //If it is not valid, for any unfulfilled rule print the corresponding message:
            //    • "Password must be between 6 and 10 characters"
            //    • "Password must consist only of letters and digits"
            //    • "Password must have at least 2 digits"


            string password = Console.ReadLine();
            bool isPasswordLengthValid = ValidatePasswordLength(password);
            bool isPasswordContainsDigitsAndLetters = ValidatePasswordCointainLettersAndDigits(password);
            bool isPasswordContainsTwoDigits = ValidatePasswordTwoDigits(password);

            if (!isPasswordLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPasswordContainsDigitsAndLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isPasswordContainsTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isPasswordContainsTwoDigits && isPasswordContainsDigitsAndLetters && isPasswordLengthValid)
            {
                Console.WriteLine($"Password is valid");
            }
        }
        private static bool ValidatePasswordLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        private static bool ValidatePasswordCointainLettersAndDigits(string password)
        {
            foreach (char digitsOrLetter in password)
            {
                if (!char.IsLetterOrDigit(digitsOrLetter))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool ValidatePasswordTwoDigits(string password)
        {
            int counter = 0;
            foreach (char digit in password)
            {
                if (char.IsDigit(digit))
                {
                    counter++;
                }
            }
            return counter >= 2;
        }
        }
    }

